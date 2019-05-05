using InjectorClass;
using Microsoft.Extensions.Logging;
using System;
using static InterfaceClass.Interfaces;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Injector inj = new Injector();
            //Example of Service locator ant-pattern
            var logger = inj.GetInstance<ILoggerClass>().GetLogger("Main");

            logger.LogInformation("Application Started");
            IFacadeClass fc = inj.GetInstance<IFacadeClass>();

            fc.DisplayStrings();

            logger.LogInformation("Application Done");
            Console.Read();
        }
    }
}
