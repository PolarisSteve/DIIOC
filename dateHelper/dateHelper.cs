using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateHelper
{
    public class dateHelper
    {
        public int getDaysInMonth()
        {
            DateTime currDate = DateTime.Now;
            return DateTime.DaysInMonth(currDate.Year, currDate.Month);
        }
    }
}
