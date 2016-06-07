using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tabaar.CheckApp
{
    public partial class FollowUpDialog : Form
    {
        public Tabaar.CheckApp.Model.FollowUpViewModel Value
        {
            get
            {
                return new Model.FollowUpViewModel
                {
                    Deliverer = this.Deliverer.Text,
                    PayCode = this.PayCode.Text,
                    PayType = this.PayType.SelectedItem.ToString(),
                    PayDate = (DateTime)this.PayDate.SelectedDateTime,
                    Amount = (int)this.Amount.Value
                };
            }
            set
            {
                Deliverer.Text = value.Deliverer;
                PayCode.Text = value.PayCode;
                PayDate.SelectedDateTime = value.PayDate;
                PayType.SelectedIndex = PayType.Items.IndexOf(value.PayType);
                Amount.Value = value.Amount;
            }
        }

        public int AmountValue
        {
            set
            {
                this.Amount.Value = value;
            }
        }
        public FollowUpDialog()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (this.Deliverer.Text == string.Empty || PayCode.Text == string.Empty || PayType.Text == string.Empty)
                return false;

            if (Amount.Value <= 0)
                return false;

            return true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                MessageBox.Show("اطلاعات را بدرستی وارد نکرده اید. لطفا دوباره بررسی نمایید.", "بررسی اطلاعات ورودی",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
