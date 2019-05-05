using Microsoft.Extensions.Logging;
using System;

namespace InterfaceClass
{
    public class Interfaces
    {
        public interface IDateFactory
        {
            DateTime getCurrentDate { get; }
        }

        public interface ILoggerClass
        {
            ILogger GetLogger(string callingModule);
        }

        public interface IDisplayDateClass
        {
            string ShowDateString { get; }
        }
        public interface IHelloWorld
        {
            string DisplayHello { get; }
        }

        public interface IFacadeClass
        {
            void DisplayStrings();
        }

    }
}
