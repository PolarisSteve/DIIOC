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
            var tstdate = new dateHelper();

            DateTime currDate = DateTime.Now;
            Assert.AreEqual(tstdate.getDaysInMonth(DateTime.Now), DateTime.DaysInMonth(currDate.Year, currDate.Month));
        }
        [TestMethod]
        public void checkFebTypical()
        {
            //This will pass one day a month and doesnt really check for February
            var tstdate = new dateHelper();

            Assert.AreEqual(tstdate.getDaysInMonth(new DateTime(2018, 2, 4)), DateTime.DaysInMonth(2018, 2));

        }
        [TestMethod]
        public void checkFebLeapYear()
        {
            //This will pass one day a month and doesnt really check for February or Leap year
            var tstdate = new dateHelper();

            Assert.AreEqual(tstdate.getDaysInMonth(new DateTime(2016, 2, 4)), DateTime.DaysInMonth(2016, 2));

        }

    }
}
