using datehelper;
using HelloWorldClass;
using System;

namespace facadeClass
{
    public class FacadeClass
    {
        HelloWorld a = new HelloWorld();
        dateHelper b = new dateHelper(DateTime.Now);

        public FacadeClass()
        {

        }

        public void DisplayStrings()
        {
            Console.WriteLine(a.DisplayHello);
            Console.WriteLine(b.ShowDateString);
        }

    }
}
