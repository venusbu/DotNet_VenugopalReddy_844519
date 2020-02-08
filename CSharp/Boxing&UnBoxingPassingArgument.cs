using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArgumentDemo
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
            //passing arguments by value type
            int i, j;
            i = 10;j = 20;
            //double sum = ShowData(ref i, j);
            //Console.WriteLine("Values of i and j = {0}, {1}", i, j);
            Console.WriteLine("values of i and j before function call = {0},{1}", i, j);

            //passing arguments by reference
            double sum = ShowData(ref i, ref j);
            
            Console.WriteLine("Values of i and j after function call = {0},{1}", i, j);
            Console.WriteLine("Sum = {0]", sum);

            Console.ReadLine();
        }
        public static double ShowData(ref int a,ref int b)
        {
            double sum = a + b;
            a += 5;
            b += 5;
            return sum;
        }
    }
}
