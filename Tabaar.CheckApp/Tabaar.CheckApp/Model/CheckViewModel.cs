using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabaar.CheckApp.Model
{
    public class CheckViewModel
    {
        public int CheckID { get; set; }

        public string SchoolCode { get; set; }

        public string StudentName { get; set; }

        /// <summary>
        /// شماره چک
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// شماره حساب چک
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// تاریخ سررسید چک
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// مبلغ چک
        /// </summary>
        public int Amount { get; set; }

        public string Bank { get; set; }

        public string Phone { get; set; }


        /// <summary>
        /// تاریخ برگشت چک
        /// </summary>
        public DateTime ReturnCheckDate { get; set; }

        public string Description { get; set; }
       
        public Status.Type StatusType { get; set; }

        public static explicit operator Check(CheckViewModel instance)
        {
            return new Check
            {
                CheckID = instance.CheckID,
                AccountNumber = instance.AccountNumber,
                Amount = instance.Amount,
                Bank = instance.Bank,
                Date = instance.Date,
                Description = instance.Description,
                Number = instance.Number,
                Phone = instance.Phone,
                ReturnCheckDate = instance.ReturnCheckDate,
                SchoolCode = instance.SchoolCode,
                StatusType = instance.StatusType,
                StudentName = instance.StudentName
            };
        }
    }
}
