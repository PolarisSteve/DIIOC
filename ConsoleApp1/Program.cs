using System;
using datehelper;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dtDay = new dateHelper(DateTime.Now);
            Console.WriteLine("Hello World!");
            Console.WriteLine(dtDay.ShowDateString);
            Console.Read();
        }
    }
}
