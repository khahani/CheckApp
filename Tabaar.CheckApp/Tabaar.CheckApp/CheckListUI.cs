using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tabaar.CheckApp.Model;
using Tabaar.CheckApp.Extension;

namespace Tabaar.CheckApp
{
    public partial class CheckListUI : Form
    {
        CheckRepository CheckRepository = new CheckRepository();

        public CheckListUI()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Logo;

            Schools.Items.Add("همه مدارس");

            foreach (var item in SchoolCollection.Current.Keys)
            {
                //Schools.Items.Add(string.Format("{0} - {1}", 
                //    item, SchoolCollection.Current[item]));
                Schools.Items.Add(SchoolCollection.Current[item]);
            }
        }

        private void CheckListUI_Load(object sender, EventArgs e)
        {
            LoadChecks();   
        }

        private void LoadChecks()
        {
            Checks.Items.Clear();

            string schoolCode = Schools.SelectedIndex < 0 ? string.Empty : SchoolCollection.GetSchoolCode(Schools.SelectedItem.ToString());

            IEnumerable<ChecksViewModel> list = CheckRepository.GetChecks(Filter.Text, schoolCode);

            int counter = 1;

            foreach (var item in list)
            {
                ListViewItem lItem = new ListViewItem
                {
                    Tag = item.CheckID,
                    Text = counter.ToString()
                };

                counter++;

                lItem.SubItems.AddRange(new string[] {
                        item.StudentName,
                        item.Number,
                        item.Date.ToPersianDate(),
                        item.Amount.ToString("#,##0"),
                        item.Bank,
                        item.Deliverer ?? string.Empty,
                        Status.GetString(item.StatusType)
                    }, Color.Black, item.StatusType == Status.Type.Delivery ? Color.LightSeaGreen : lItem.BackColor, this.Font);


                Checks.Items.Add(lItem);
            }

            this.SearchResultCounter.Text = string.Format("تعداد چک ها: {0}", (counter - 1).ToString());
        }

        private void Checks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Checks.SelectedItems.Count == 0)
                return;

            CheckDialog dialog = new CheckDialog();

            dialog.Value = CheckRepository.GetCheck((int)Checks.SelectedItems[0].Tag);

            dialog.ShowDialog();

            LoadChecks();
        }

        private void LoadChecks_OnFilterChanges(object sender, EventArgs e)
        {
            LoadChecks();
        }

        private void AddCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckDialog dialog = new CheckDialog();

            dialog.ShowDialog();

            LoadChecks();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomAboutDialog dialog = new CustomAboutDialog();

            dialog.ShowDialog();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Checks.SelectedItems.Count < 0)
            {
                MessageBox.Show("لطفا چک مورد نظر را انتخاب نمایید. برای این کار روی یکی از چک های فهرست زیر کلیک نمایید.", 
                    "عدم انتخاب چک", MessageBoxButtons.OK,MessageBoxIcon.Hand);

                return;
            }

            int checkId = (int)Checks.SelectedItems[0].Tag;

            CheckRepository checkRepository = new CheckRepository();

            if (!checkRepository.HasFollowUp(checkId))
            {
                MessageBox.Show("این چک فاقد اطلاعات پیگیری می باشد، لذا امکان چاپ رسید وجود ندارد.",
                    "چک فاقد اطلاعات پیگیری", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            ReportUI dialog = new ReportUI
            {
                CheckID = checkId
            };

            dialog.ShowDialog();
        }
    }
}
