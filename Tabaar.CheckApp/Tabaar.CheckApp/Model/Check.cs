using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tabaar.CheckApp.Model
{
    public class Check
    {
        [Key]
        public int CheckID { get; set; }

        /// <summary>
        /// شماره چک
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// مبلغ چک
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// تاریخ سررسید چک
        /// </summary>
        public DateTime Date { get; set; }

        public string Phone { get; set; }
        /// <summary>
        /// شماره حساب چک
        /// </summary>
        public string AccountNumber { get; set; }

        public string Description { get; set; }
        public string SchoolCode { get; set; }
        public string StudentName { get; set; }
        /// <summary>
        /// تاریخ برگشت چک
        /// </summary>
        public DateTime ReturnCheckDate { get; set; }
        public string Bank { get; set; }
        public Status.Type StatusType { get; set; }

        //Check Delivery
        public string Deliverer { get; set; }
        public string PayType { get; set; }
        public string PayCode { get; set; }
        /// <summary>
        /// تاریخ پرداخت مبلغ چک
        /// </summary>
        public DateTime? PayDate { get; set; }

        public int? PayAmount { get; set; }

        public void UpdateBy(CheckViewModel instance)
        {
            CheckID = instance.CheckID;
            AccountNumber = instance.AccountNumber;
            Amount = instance.Amount;
            Bank = instance.Bank;
            Date = instance.Date;
            Description = instance.Description;
            Number = instance.Number;
            Phone = instance.Phone;
            ReturnCheckDate = instance.ReturnCheckDate;
            SchoolCode = instance.SchoolCode;
            StatusType = instance.StatusType;
            StudentName = instance.StudentName;
        }

        public void UpdateBy(FollowUpViewModel instance)
        {
            Deliverer = instance.Deliverer;
            PayAmount = instance.Amount;
            PayCode = instance.PayCode;
            PayDate = instance.PayDate;
            PayType = instance.PayType;
        }

        public static explicit operator ChecksViewModel(Check instance)
        {
            return new ChecksViewModel
            {
                CheckID = instance.CheckID,
                Amount = instance.Amount,
                Bank = instance.Bank,
                Date = instance.Date,
                Number = instance.Number,
                SchoolCode = instance.SchoolCode,
                StatusType = instance.StatusType,
                StudentName = instance.StudentName,
                Deliverer = instance.Deliverer
            };
        }

        public static explicit operator CheckViewModel(Check instance)
        {
            return new CheckViewModel
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
