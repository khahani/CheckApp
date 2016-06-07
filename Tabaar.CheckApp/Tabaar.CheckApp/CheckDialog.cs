using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tabaar.CheckApp.Model;

namespace Tabaar.CheckApp
{
    public partial class CheckDialog : Form
    {
        private ICheckRepository CheckRepository;

        private bool _HasChanges;

        public CheckViewModel Value
        {
            get
            {
                return new CheckViewModel
                {
                    CheckID = Tag == null ? 0 :(int)Tag,
                    AccountNumber = AccountNumber.Text,
                    Number = CheckNumber.Text,
                    Bank = Bank.Text,
                    Date = CheckDate.SelectedDateTime,
                    Description = Description.Text,
                    Amount = (int)Amount.Value,
                    Phone = Phone.Text,
                    ReturnCheckDate = ReturnDate.SelectedDateTime,
                    SchoolCode = SchoolCode.Text,
                    StudentName = Student.Text,
                    StatusType = Tabaar.CheckApp.Model.Status.GetStatusType(Status.SelectedItem.ToString())
                };
            }
            set
            {
                this.Tag = value.CheckID;
                AccountNumber.Text = value.AccountNumber;
                CheckNumber.Text = value.Number;
                Bank.Text = value.Bank;
                CheckDate.SelectedDateTime = value.Date;
                Description.Text = value.Description;
                Amount.Value = value.Amount;
                Phone.Text = value.Phone;
                ReturnDate.SelectedDateTime = value.ReturnCheckDate;
                SchoolCode.Text = value.SchoolCode;
                SchoolName.Text = SchoolCollection.GetSchoolName(value.SchoolCode);
                Student.Text = value.StudentName;
                Status.SelectedIndex = Status.Items.IndexOf(Tabaar.CheckApp.Model.Status.GetString(value.StatusType));

                bool hasFollowUp = CheckRepository.HasFollowUp(value.CheckID);

                FollowUp.ImageIndex = hasFollowUp ? 0 : 1;

                if (hasFollowUp)
                    _FollowUpValue = CheckRepository.GetFollowUp(value.CheckID);
            }
        }

        private FollowUpViewModel _FollowUpValue;

        private Dictionary<string, string> Schools = SchoolCollection.Current;

        public CheckDialog()
        {
            InitializeComponent();

            this.Status.Items.AddRange(Model.Status.StatusList());

            CheckRepository = new CheckRepository();
        }

        private void SchoolCode_Validating(object sender, CancelEventArgs e)
        {
            if (SchoolCode.Text == string.Empty)
                return;

            bool exists = false;

            foreach (var item in Schools.Keys)
            {
                if (SchoolCode.Text == item)
                {
                    SchoolName.Text = Schools[item];
                    exists = true;
                }
            }

            if (!exists)
            {
                MessageBox.Show("مدرسه ای با این کد در سیستم وجود ندارد. لطفا کد مدرسه را دوباره بررسی نمایید.",
                    "بررسی کد مدرسه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);

                this.SchoolCode.Focus();
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            Tag = 0;

            foreach (var item in GroupBox.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = string.Empty;
                }
                else if (item is Controls.PersianDate)
                {
                    (item as Controls.PersianDate).ResetDate();
                }
                else if (item is NumericUpDown)
                {
                    (item as NumericUpDown).Value = 0;
                }
                else if (item is ComboBox)
                {
                    (item as ComboBox).SelectedIndex = 0;
                }
            }

            SchoolName.Text = "نام مدرسه";

        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Status.SelectedItem.ToString() == Model.Status.GetString(Model.Status.Type.Delivery))
            {
                this.BackColor = Color.LightSkyBlue;
                this.FollowUp.Visible = true;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.FollowUp.Visible = false;
            }
        }

        private void FollowUp_Click(object sender, EventArgs e)
        {
            FollowUpDialog dialog = new FollowUpDialog();

            if (_FollowUpValue != null)

                dialog.Value = _FollowUpValue;

            else

                dialog.AmountValue = Value.Amount;

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            _FollowUpValue = dialog.Value;

            this.FollowUp.ImageIndex = 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show("اطلاعات فرم بدرستی وارد نشده است. لطفا پس از بررسی نسبت به ذخیره سازی اقدام نمایید.",
                    "بررسی اطلاعات",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
                
            }
            if (Value.StatusType == Model.Status.Type.Delivery && FollowUp.ImageIndex == 1)
            {
                MessageBox.Show(
                    string.Format("امکان ثبت چک در وضعیت {0} وجود ندارد.\n مشخصات تحویل گیرنده را در قسمت پیگیری وارد نکرده اید. ", 
                    Model.Status.GetString(Value.StatusType)), "بررسی اطلاعات چک",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (Value.StatusType != Model.Status.Type.Delivery && _FollowUpValue != null)
            {
                DialogResult result = MessageBox.Show(
                    string.Format("به دلیل تغییر وضعیت چک از {0} به {1} اطلاعات پیگیری حذف خواهد شد. آیا با این موضوع موافق هستید؟",
                        Model.Status.GetString(Model.Status.Type.Delivery), Model.Status.GetString(Value.StatusType)),
                        "بررسی اطلاعات چک",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result != System.Windows.Forms.DialogResult.Yes)
                {
                    Status.SelectedIndex = Status.Items.IndexOf(Model.Status.GetString(Model.Status.Type.Delivery));
                    return;
                }

                CheckRepository.ClearFollowUp(Value.CheckID);

                _FollowUpValue = null;

                FollowUp.ImageIndex = 1;
            }

            CheckRepository repository = new CheckRepository();

            this.Tag = repository.SaveCheck(Value);

            if (_FollowUpValue != null && Value.StatusType == Model.Status.Type.Delivery)

                repository.SaveFollowUp(Value.CheckID, _FollowUpValue);

            MessageBox.Show("اطلاعات چک با موفقیت ذخیره شد.", "ذخیره سازی اطلاعات...", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

            if (_FollowUpValue != null && Value.StatusType == Model.Status.Type.Delivery)
            {
                if (MessageBox.Show("آیا تمایل به چاپ رسید چک برگشتی دارید؟", "چاپ رسید چک برگشتی",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)

                    return;

                ReportUI report = new ReportUI();

                report.CheckID = (int)this.Tag;

                report.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            CheckRepository repository = new CheckRepository();

            DialogResult resule = MessageBox.Show("آیا از حذف چک اطمینان دارید؟", "حذف چک",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resule != System.Windows.Forms.DialogResult.Yes)

                return;

            repository.DeleteCheck(Value);

            ResetForm();

            MessageBox.Show("چک با موفقیت حذف گردید.", "حذف چک", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid()
        {
            foreach (var item in GroupBox.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Text == string.Empty)
                        return false;
                }
                else if (item is Controls.PersianDate)
                {
                    if ((item as Controls.PersianDate).SelectedDateTime == null)
                        return false;
                }
                else if (item is NumericUpDown)
                {
                    if ((item as NumericUpDown).Value == 0)
                        return false;
                }
                else if (item is ComboBox)
                {
                    if ((item as ComboBox).SelectedIndex < 0)
                        return false;
                }
            }


            return true;
        }
    }
}
