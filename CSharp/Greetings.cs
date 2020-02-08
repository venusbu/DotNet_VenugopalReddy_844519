using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            Console.WriteLine("enter first number\n");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            n2 = float.Parse(Console.ReadLine());

            double result = n1 * n2;
            Console.WriteLine("the product of {0} and {1} = {2}", n1, n2, result);
            var message = Greetings(35, "jeffery");
            Console.WriteLine(message);
            Console.ReadKey();

        }
        public static string Greetings(int age,string name)
        {
            return string.Format("Congratulations Me/Mrs {0} on your {1} Birthday", name, age);
        }
    }
}
