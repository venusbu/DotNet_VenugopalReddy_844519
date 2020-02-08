using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace control_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            if (a > 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (a<10)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
            int b = 3;
            switch(b)
            {
                case 1:
                    {
                        Console.WriteLine("Hello, how are you");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Hi, how do you do");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Hope, you are well");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("It seems you are not keeping well");
                        break;
                    }
                
            }
            
        }
    }
}
