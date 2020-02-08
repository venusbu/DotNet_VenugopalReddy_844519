using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14primenumbers
{
    class Program
    {
        public static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the array elements");
            for (int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());


            }
            var ev = from e in a
                     where e % 2 == 0
                     select e;
            Console.WriteLine("The Even numbers Are:");
            foreach (var i in ev)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
