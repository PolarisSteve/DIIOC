using System;
using facadeClass;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeClass fc = new FacadeClass();
            fc.DisplayStrings();
            Console.Read();
        }
    }
}
