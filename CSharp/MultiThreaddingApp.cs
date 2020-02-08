using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread is started");
            Thread t = Thread.CurrentThread;
            //t.Name = "Sub Thread";
            //Method1();
            //Method2();
            //Method3();
            Thread T1 = new Thread(new ThreadStart(Method1));
            Thread T2 = new Thread(Method2);
            Thread T3 = new Thread(Method3);

            T1.Start();
            T2.Start();
            T3.Start();


            Thread Tp = new Thread(new ParameterizedThreadStart(Test));
            Tp.Start(100);


            T1.Join(); T2.Join(); T3.Join();Tp.Join();
            Thread Tarea = new Thread(new ThreadStart(FindArea));
            //Tarea.Start();
            Console.WriteLine("Main thread is executed");
            Console.ReadKey();
        }
        public static void Method1()
        {
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("Method1: {0}", i);
        }
        public static void Method2()
        {
            for (int i = 1; i < 50; i++)
            {
                if (i == 25)
                {
                    Thread.Sleep(50000);
                }
                Console.WriteLine("Method2: {0}", i);
            }  
        }
        public static void Method3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method3: {0}", i);
            }
        }
        public static void Test(object max)
        {
            int j = Convert.ToInt32(max);
            for (int i=1; i<=j; i++)
            {
                Console.WriteLine("Test ={0} ", i);
            }
        }
        public static void FindArea()
        {
            //var len, bred;

            Console.WriteLine("enter length");
            var len = double.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth");
            var bred = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of rectangle: {0}", (len * bred));
        }
    }
}
