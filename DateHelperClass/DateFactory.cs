using System;
using System.Collections.Generic;
using System.Text;

namespace DateHelperClass
{
    public class DateFactory : IDateFactory
    {
        public DateTime getCurrentDate => DateTime.Now;
    }
}
