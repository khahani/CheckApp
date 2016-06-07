using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabaar.CheckApp.Model.Report
{
    public class DeliveryReceipt
    {
        public string SchoolName { get; set; }

        public string CheckNumber { get; set; }

        public string CheckDate { get; set; }

        public int Amount { get; set; }

        public string AccountNumber { get; set; }

        public string Bank { get; set; }

        public string ReturnDate { get; set; }

        /// <summary>
        /// //Check Deliverer is student parent
        /// </summary>
        public string StudentParent { get; set; }

        public string StudentName { get; set; }

        public string Phone { get; set; }

        public string TodayDate { get; set; }
    }
}
