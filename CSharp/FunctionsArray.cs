using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class sample
    {
        public int i;
        public int[] arr = new int[10];
        public void fun(int i, int val)
        {
            arr[i] = val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            s.i = 10;
          //  sample.fun(1, 5);
            s.fun(1, 5);
            Console.WriteLine("arrary of 1 {0}:", s.arr[1]);
            Console.ReadLine();
        }
    }
}
