using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceClass.Interfaces;

namespace DateHelperClass
{
    public class DateFactory : IDateFactory
    {
        public DateTime getCurrentDate => DateTime.Now;
    }
}
