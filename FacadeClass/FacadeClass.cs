using Microsoft.Extensions.Logging;
using System;
using static InterfaceClass.Interfaces;


namespace facadeClass
{
    public class FacadeClass : IFacadeClass
    {
        IHelloWorld a;
        IDisplayDateClass b;
        ILogger _lg;

        public FacadeClass(IHelloWorld hw, IDisplayDateClass dd, ILoggerClass lg)
        {
            a = hw;
            b = dd;
            _lg = lg.GetLogger("Facade Class");
        }

        public void DisplayStrings()
        {
            _lg.LogInformation("------------");
            Console.WriteLine(a.DisplayHello);
            Console.WriteLine(b.ShowDateString);
            _lg.LogInformation("------------");
        }

    }
}
