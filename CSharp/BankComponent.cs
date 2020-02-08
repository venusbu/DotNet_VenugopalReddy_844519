using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComponent;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsBank s = new SavingsBank();
            var SI = s.GetSimpleIntrest(15000, 26, 5.6);
            Console.WriteLine("The simple interest is {0}", SI);
            var TotalBal=s.GetTotalBalance(15000,SI);
            Console.WriteLine("The total balance is {0}", TotalBal);
        }
    }
}
