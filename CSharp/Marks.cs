using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6];
            marks[0] = 89;
            marks[1] = 90;
            marks[2] = 91;
            marks[3] = 92;
            marks[4] = 93;
            marks[5] = 94;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Marks c# programming = {0}", marks[i]);
            }
            Console.ReadKey();
        }
    }

}
