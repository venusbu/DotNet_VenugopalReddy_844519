using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSample
{
    class Program
    { 
        static void Main(string[] args)
        {
            int empage;
            string empname;
            char empgen;
            Console.WriteLine("Enter the Employee Name");
            empname = Console.ReadLine();
            Console.WriteLine("Enter the Employee age");
            empage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the gender");
            empgen = char.Parse(Console.ReadLine());
            if (empgen == 'm')
            {
                Console.WriteLine("Congratulations Mr {0} on your {1} Birthday", empname, empage, empgen);
            }
            else if(empgen == 'f')
            {
                Console.WriteLine("Congratulations Mrs {0} on your {1} Birthday", empname, empage, empgen);
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
