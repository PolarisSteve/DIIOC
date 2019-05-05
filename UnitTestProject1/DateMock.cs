using DateHelperClass;
using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceClass.Interfaces;

namespace UnitTestProject1
{
    public class DateMock : IDateFactory
    {
        DateTime dtPassed;

        public DateMock(DateTime dt)
        {
            dtPassed = dt;
        }

        public DateTime getCurrentDate => dtPassed;
    }
}
