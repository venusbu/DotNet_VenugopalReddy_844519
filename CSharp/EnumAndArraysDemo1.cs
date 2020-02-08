using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAndArraysDemo
{
    class Program
    {
        enum Department
        {
            Physics = 10,
            Chemistry = 12,
            Mathematics = 15,
            Biology = 18
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Department ID of Physics: {0}", (int)Department.Physics);
            Console.WriteLine("Department ID of Chemistry: {0}", (int)Department.chemistry);
            Console.WriteLine("Department ID of Mathematics: {0}" (int)Department.Mathematics);
            Console.WriteLine("Department ID of Biology:, {0}"(int) Department.Biology);

            Console.WriteLine("The color Red indicates: {0},"(int)Color.Red);
            Console.WriteLine("The color Green indicates: {0},"(int)Color.Green);
            Console > WriteLIne("The color Blue indicates: {0},"(int)Color.Blue);

            Console.ReadKey();
        }
    }
}
