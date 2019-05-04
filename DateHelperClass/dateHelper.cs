using System;
using static InterfaceClass.Interfaces;

namespace DateHelperClass
{
    public class dateHelper : IDisplayDateClass
    {
        DateTime dt;

        public dateHelper(IDateFactory currDate)
        {
            dt = currDate.getCurrentDate;
        }
        private int getDaysInMonth()
        {
            return DateTime.DaysInMonth(dt.Year, dt.Month);
        }
        public string ShowDateString { get { return string.Format("The number of days in the month is: {0}", getDaysInMonth().ToString()); } }


    }
}
