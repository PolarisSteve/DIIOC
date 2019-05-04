using InjectorClass;
using System;
using static InterfaceClass.Interfaces;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Injector inj = new Injector();
            IFacadeClass fc = inj.GetInstance<IFacadeClass>();

            fc.DisplayStrings();
            Console.Read();
        }
    }
}
