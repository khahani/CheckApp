using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Tabaar.CheckApp.Controls
{
    public partial class PersianDate : UserControl
    {
        public PersianDate()
        {
            InitializeComponent();

            SelectedDateTime = DateTime.Now;

            Initialize(Day, 1, 31, false);
            Initialize(Month, 1, 12, false);
            Initialize(Year, 1395, 1370, true);

            ResetDate();
        }

        public DateTime SelectedDateTime
        {
            get
            {
                PersianCalendar calendar = new PersianCalendar();
               
                DateTime date = calendar.ToDateTime(int.Parse(Year.SelectedItem.ToString()),
                    int.Parse(Month.SelectedItem.ToString()),
                    int.Parse(Day.SelectedItem.ToString()), 0, 0, 0, 0);

                    return date;
               
            }
            set
            {
                PersianCalendar calendar = new PersianCalendar();

                Year.SelectedIndex = Year.Items.IndexOf(calendar.GetYear(value));
                Month.SelectedIndex = Month.Items.IndexOf(calendar.GetMonth(value));
                Day.SelectedIndex = Day.Items.IndexOf(calendar.GetDayOfMonth(value));
            }
        }

        private void Initialize(ComboBox control, int from, int to, bool reverse)
        {
            if (!reverse)
                for (int i = from; i <= to; i++)
                {
                    control.Items.Add(i);
                }
            else
                for (int i = from; i >= to; i--)
                {
                    control.Items.Add(i);
                }
        }

        public void ResetDate()
        {
            this.Day.SelectedIndex = this.Month.SelectedIndex = this.Year.SelectedIndex = 0;
        }
    }
}
