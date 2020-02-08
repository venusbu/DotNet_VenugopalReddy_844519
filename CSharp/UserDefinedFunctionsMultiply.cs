using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 9; b = 5;
            Multiply(a, b);
            for (int i = 1; i <= 5; i++)
            {
                var result = 85 + i;
                Console.WriteLine("result = {0}", result);
            }
        }

        public static double Multiply(int a, int b)
        {
            var prod = a * b;
            return prod;
        }
    }
}
