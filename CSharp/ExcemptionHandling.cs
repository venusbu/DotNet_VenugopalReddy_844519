using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] marks = new int[6] { 85, 89, 93, 94, 95, 98 };
                for (int i = 0; i <= 6; i++)
                {
                    Console.WriteLine("Subject marks {0} = {1}", i + 1, marks[i]);
                }
            }
            Catch (Exception e)
                {
                Console.WriteLine(e.message);
                Console.WriteLine(e.stackTrace);
                }
           
        }
        if(b==0)
            {
            throw new DivideByZeroException("Denominator )
    }
}
