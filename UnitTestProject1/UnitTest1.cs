using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using datehelper;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkCurrentDay()
        {
            //This will always pass
            var tstdate = new dateHelper(DateTime.Now);

            Assert.AreEqual(
                tstdate.ShowDateString,
                string.Format("The number of days in the month is: {0}", DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString())
            );
        
        }


        [TestMethod]
        public void checkFebTypical()
        {
            //This will pass one day a month and doesnt really check for February
            var tstdate = new dateHelper(new DateTime(2018, 2, 4));

            Assert.AreEqual(
                tstdate.ShowDateString,
                string.Format("The number of days in the month is: {0}", DateTime.DaysInMonth(2018, 2).ToString())
            );


        }
        [TestMethod]
        public void checkFebLeapYear()
        {
            //This will pass one day a month and doesnt really check for February or Leap year
            var tstdate = new dateHelper(new DateTime(2016, 2, 4));

            Assert.AreEqual(
                tstdate.ShowDateString,
                string.Format("The number of days in the month is: {0}", DateTime.DaysInMonth(2016, 2).ToString())
            );
        }

    }
}
