using System;
using static InterfaceClass.Interfaces;

namespace facadeClass
{
    public class FacadeClass : IFacadeClass
    {
        IHelloWorld a;
        IDisplayDateClass b;

        public FacadeClass(IHelloWorld hw, IDisplayDateClass dd)
        {
            a = hw;
            b = dd;
        }

        public void DisplayStrings()
        {
            Console.WriteLine(a.DisplayHello);
            Console.WriteLine(b.ShowDateString);
        }

    }
}
