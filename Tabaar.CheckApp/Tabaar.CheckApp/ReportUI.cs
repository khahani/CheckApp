using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Tabaar.CheckApp.Model;
using Tabaar.CheckApp.Extension;
using Tabaar.CheckApp.Model.Report;

namespace Tabaar.CheckApp
{
    public partial class ReportUI : Form
    {
        private ICheckRepository CheckRepository;

        public ReportUI()
        {
            InitializeComponent();

            CheckRepository = new CheckRepository();
        }
        public int CheckID { get; set; }

        private void MainUI_Load(object sender, EventArgs e)
        {
            DeliveryReceipt deliveryReceipt = CheckRepository.GetDeliveryReceipt(CheckID);

            DeliveryReceiptBindingSource.Add(deliveryReceipt);

            this.reportViewer1.RefreshReport();
        }
    }
}
