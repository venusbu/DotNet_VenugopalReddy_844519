using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum Weeks
        {
            Sunday = 1
            Monday,
            Tuesday,
            Wednesday,
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Week of Sunday: {0}", (int)Week.Sunday);
            Console.WriteLine("Week of Monday: {0}", (int)Week.Monday);
            Console.WriteLine("Week of Tuesday: {0}", (int)Week.Tuesday);
            Console.WriteLine("Week of Wednesday: {0}", (int)Week.Wednesday;

            Console.ReadKey();
        }
    }
}
