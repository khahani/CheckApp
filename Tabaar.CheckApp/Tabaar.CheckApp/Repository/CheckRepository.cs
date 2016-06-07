using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabaar.CheckApp.Model;
using Tabaar.CheckApp.Model.Report;
using Tabaar.CheckApp.Extension;

namespace Tabaar.CheckApp
{
    public class CheckRepository : ICheckRepository
    {
        CheckDatabase db = new CheckDatabase();

        public int SaveCheck(Model.CheckViewModel check)
        {
            var existsCheck = db.Checks.Find(check.CheckID);

            if (existsCheck == null)
            {
                existsCheck = (Check)check;
                db.Checks.Add(existsCheck);
            }
            else

                existsCheck.UpdateBy(check);

            db.SaveChanges();

            return existsCheck.CheckID;
        }

        public void DeleteCheck(Model.CheckViewModel check)
        {
            var existsCheck = db.Checks.Find(check.CheckID);

            db.Checks.Remove(existsCheck);

            db.SaveChanges();
        }

        public void SaveFollowUp(int checkId, Model.FollowUpViewModel followUp)
        {
            var check = db.Checks.Where(c => c.CheckID == checkId).FirstOrDefault();

            if (check != null)

                check.UpdateBy(followUp);

            db.SaveChanges();
        }


        public IEnumerable<ChecksViewModel> GetChecks(string filter, string schoolCode)
        {
            try
            {
                db = new CheckDatabase();

                Check[] checks;

                if (filter != string.Empty)

                    checks = db.Checks.Where(c =>
                    c.Bank.Contains(filter) || c.Deliverer.Contains(filter) ||
                    c.Number.Contains(filter) || c.PayCode.Contains(filter) ||
                    c.StudentName.Contains(filter)).ToArray();

                else

                    checks = db.Checks.ToArray();

                if (schoolCode != string.Empty)

                    checks = checks.Where(c => c.SchoolCode == schoolCode).ToArray();


                return Array.ConvertAll(checks, c => (ChecksViewModel)c);
            }
            catch(Exception ex)
            {
                return new ChecksViewModel[1];
            }
        }

        public CheckViewModel GetCheck(int checkId)
        {
            return (CheckViewModel)db.Checks.Where(c => c.CheckID == checkId).FirstOrDefault();
        }

        public FollowUpViewModel GetFollowUp(int checkId)
        {
            return db.Checks.Where(c => c.CheckID == checkId)
                .Select(c => new FollowUpViewModel
                                {
                                    Deliverer = c.Deliverer,
                                    Amount = c.Amount,
                                    PayCode = c.PayCode,
                                    PayDate = c.PayDate ?? DateTime.Now,
                                    PayType = c.PayType
                                }).FirstOrDefault();
        }

        public void ClearFollowUp(int checkId)
        {
            var check = db.Checks.Where(c => c.CheckID == checkId).FirstOrDefault();

            check.Deliverer = null;
            check.PayType = null;
            check.PayCode = null;
            check.Amount = 0;
            check.PayDate = DateTime.Now;

            db.SaveChanges();
        }

        public bool HasFollowUp(int checkId)
        {
            return !string.IsNullOrEmpty(db.Checks.Where(c => c.CheckID == checkId).FirstOrDefault().PayCode);
        }

        public DeliveryReceipt GetDeliveryReceipt(int checkId)
        {
            var check = db.Checks.Where(c => c.CheckID == checkId).FirstOrDefault();

            return new DeliveryReceipt
            {
                SchoolName = SchoolCollection.GetSchoolName(check.SchoolCode),
                TodayDate = DateTime.Now.ToPersianDate(),
                CheckNumber = check.Number,
                CheckDate = check.Date.ToPersianDate(),
                Amount = check.Amount,
                AccountNumber = check.AccountNumber,
                Bank = check.Bank,
                ReturnDate = check.ReturnCheckDate.ToPersianDate(),
                StudentParent = check.Deliverer,
                StudentName = check.StudentName,
                Phone = check.Phone
            };
        }
    }
}
