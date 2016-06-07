using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabaar.CheckApp.Model
{
    public class FollowUpViewModel
    {
        public string Deliverer { get; set; }
        public string PayType { get; set; }
        public string PayCode { get; set; }
        public DateTime PayDate { get; set; }
        public int Amount { get; set; }
    }
}
