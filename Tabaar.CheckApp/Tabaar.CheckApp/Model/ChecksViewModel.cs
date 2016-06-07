using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabaar.CheckApp.Model
{
    public class ChecksViewModel
    {
        public int CheckID { get; set; }

        public string SchoolCode { get; set; }

        public string SchoolName
        {
            get
            {
                return SchoolCollection.GetSchoolName(SchoolCode);
            }
        }

        public string StudentName { get; set; }

        /// <summary>
        /// شماره چک
        /// </summary>
        public string Number { get; set; }

        
        /// <summary>
        /// تاریخ سررسید چک
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// مبلغ چک
        /// </summary>
        public int Amount { get; set; }

        public string Bank { get; set; }

        public string Deliverer { get; set; }

        public Status.Type StatusType { get; set; }

       
    }
}
