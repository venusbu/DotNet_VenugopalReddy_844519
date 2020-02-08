using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsDemo2
{
    class Program
    {
        public delegate void MathDelegate(double a, double b);
        static void Main(string[] args)
        {
            MathDelegate m = new MathDelegate(Add);
            m += Sub;
            m += mul;
            m += div;
            m.Invoke(950, 11);
            
            Console.ReadKey();
        }
        public static void Add(double a, double b)
        {
            var s = (a + b);
            Console.WriteLine("The addition of {0} and {1} is {2}", a, b, s);
        }
        public static void Sub(double a, double b)
        {
            var s = (a - b);
            Console.WriteLine("The Subtraction of {0} and {1} is {2}", a, b, s);
        }
        public static void mul(double a, double b)
        {
            var s = (a * b);
            Console.WriteLine("The Multiplication of {0} and {1} is {2}", a, b, s);
        }
        public static void div(double a, double b)
        {
            var s = (a / b);
            Console.WriteLine("The Division of {0} and {1} is {2}", a, b, s);
        }
    }
}
