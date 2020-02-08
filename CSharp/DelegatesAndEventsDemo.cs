using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsDemo
{
    class Program
    {
        public delegate double SalDelegate(int ds, float sd);
        static void Main(string[] args)
        {
            SalDelegate deleg = new SalDelegate(GetSalary);
            var salary = deleg.Invoke(30, 800);
            Console.WriteLine("Salary = {0}", salary);
            deleg += GetIncentives;
            var incent = deleg.Invoke(30, 800);
            Console.WriteLine("Incentives = {0}", incent);
            Console.ReadKey();
        }
        public static double GetSalary(int nds,float spd)
        {
            var salary = ( nds + spd );
            return salary;
        }
        public static double GetIncentives(int nds, float spd)
        {
            var incent = 0.1 * (nds + spd);
            return incent;
        }
    }
}
