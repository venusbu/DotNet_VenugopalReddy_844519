using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MultiThreadedAppPerform
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();

            s1.Start();
            IncrementCount1();
            IncrementCount2();
            s1.Stop();

            Stopwatch s2 = new Stopwatch();

            Thread T1 = new Thread(IncrementCount1);
            Thread T2 = new Thread(IncrementCount2);

            s2.Start();
            T1.Start();
            T2.Start();
            s1.Stop();

            T1.Join();
            T2.Join();

            Console.WriteLine("Total Time Elapsed for a Single Threaded Application: {0}", s1.ElapsedMilliseconds);
            Console.WriteLine("Total Time Elapsed for a Multi Threaded Application: {0}", s2.ElapsedMilliseconds);

            Console.WriteLine("Main thread has exited");
        }
        public static void IncrementCount1()
        {
            long Count1 = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                Count1 += 1;
            }
                Console.WriteLine("Count1: {0}", Count1);
            
        }
        public static void IncrementCount2()
        {
            long Count2 = 0;
            for (int i = 1; i <= 1000; i++)
            {
                Count2 += 1;
            }
                Console.WriteLine("Count2: {0}", Count2);
           
        }
    }
}
