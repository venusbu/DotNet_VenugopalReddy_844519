using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 9; b = 5;
            Multiply(a, b);
        }

        public static double Multiply(int a, int b)
        {
            var prod = a + b;
            return prod;
        }
    }
}
