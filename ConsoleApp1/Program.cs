using System;
using datehelper;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dtDay = new dateHelper();
            Console.WriteLine("Hello World!");
            Console.WriteLine(string.Format("The number of days in the month is: {0}", dtDay.getDaysInMonth().ToString()));
            Console.Read();
        }
    }
}
