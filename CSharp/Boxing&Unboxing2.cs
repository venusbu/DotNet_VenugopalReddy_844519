using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
                //Boxing and UnBoxing
                object obj = 100; //object is a reference type
                int a = 10;
                obj = a;
                int b = (int)a; //Unboxing 
                Console.WriteLine("Values of a and b {0} and {1}", a, b);

            int i,j;
            i = 10; j = 20;
            Console.WriteLine("values of i and j before function call = {0},{1}", i, j);
            ShowData1( i,  j);
            Console.WriteLine("Values of i and j after function call = {0},{1}", i, j);
            //passing arguments by value type

            int k,l;
                k = 10; l = 20;
                Console.WriteLine("values of k and l before function call = {0},{1}", k, l);
                ShowData2(ref  k, ref  l);
                Console.WriteLine("Values of k and l after function call = {0},{1}", k, l);

                Console.ReadLine();
        }
            public static double ShowData1(int a, int b)
            {
                double sum = a + b;
                Console.WriteLine("Sum = {0}", sum);
            a += 5;
                b += 5;
                return sum;
            }
        public static double ShowData2(ref int a,ref int b)
        {
            double sum = a + b;
            Console.WriteLine("Sum = {0}", sum);
            a += 5;
            b += 5;
            return sum;
        }
    }
}
