using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceClass.Interfaces;

namespace InjectorClass
{
    

    public class LoggerClass : ILoggerClass
    {

        ILoggerFactory _lg;

        public LoggerClass(ILoggerFactory lg)
        {
            _lg = lg;
        }

        public ILogger GetLogger(string callingModule)
        {
            return _lg.CreateLogger(callingModule);

        }
        
    }
}
