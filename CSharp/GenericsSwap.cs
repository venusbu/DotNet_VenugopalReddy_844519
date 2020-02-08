using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cgeneric_methodusingswap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 50;b = 30;

            Console.WriteLine("Before swap: a = {0}, b = {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: a= {0}, b = {1}", a, b);
            string s1, s2;

            s1 = "hello";
            s2 = "world";
            Console.WriteLine("Before swap: s1 = {0}, s2 = {1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: s1 = {0}, s2 = {1}", s1, s2);
            Console.ReadKey();
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }
}
