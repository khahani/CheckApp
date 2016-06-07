using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabaar.CheckApp.Extension
{
    public static class PersianDateHelper
    {
        public static string ToPersianDate(this DateTime date)
        {
            PersianCalendar p = new PersianCalendar();

            return string.Format("{0}/{1}/{2}",
                    p.GetYear(date),
                    p.GetMonth(date),
                    p.GetDayOfMonth(date)
                );
        }
    }
}
