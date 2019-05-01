using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datehelper
{
    public class dateHelper
    {
        DateTime dt;

        public dateHelper(DateTime currDate)
        {
            dt = currDate;
        }
        private int getDaysInMonth()
        {
            
            return DateTime.DaysInMonth(dt.Year, dt.Month);
        }
        public string ShowDateString { get { return string.Format("The number of days in the month is: {0}", getDaysInMonth().ToString()); } }

    }
}
