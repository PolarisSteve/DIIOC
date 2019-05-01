using System;

namespace InterfaceClass
{
    public class Interfaces
    {
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
