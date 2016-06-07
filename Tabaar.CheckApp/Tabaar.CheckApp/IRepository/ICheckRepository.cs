using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabaar.CheckApp.Model;
using Tabaar.CheckApp.Model.Report;

namespace Tabaar.CheckApp
{
    public interface ICheckRepository
    {
        CheckViewModel GetCheck(int id);

        int SaveCheck(CheckViewModel check);

        void DeleteCheck(CheckViewModel check);

        void SaveFollowUp(int checkId, FollowUpViewModel followUp);

        IEnumerable<ChecksViewModel> GetChecks(string filter, string schoolCode);

        bool HasFollowUp(int checkId);

        FollowUpViewModel GetFollowUp(int checkId);

        void ClearFollowUp(int checkId);

        DeliveryReceipt GetDeliveryReceipt(int checkId);
    }
}
