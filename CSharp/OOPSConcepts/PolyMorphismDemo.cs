using System;

namespace PolyMorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            var salary = emp.GetSalary(30, 800);
            Console.WriteLine("Salary with incentives: Rs {0}", salary);

            salary = emp.GetSalary(30, 800, 5000);
            Console.WriteLine("Salary with incentives: Rs {0}", salary);

            Manager objM = new Manager();
            var ts = objM.GetPerks(30000, 5000);
            Console.WriteLine("Salary of Manager: Rs {0}", ts);

            Console.ReadKey();
        }
    }
    public class Employee
    {
        public double GetSalary(int nds,float spd)
        {
            double salary = nds * spd;
            return salary;
        }
        public double GetSalary(int nds, float spd, float incent)
        {
            double salary = (nds * spd) + incent;
            return salary;
        }
        public virtual double GetPerks(float salary, float perks)
        {
            double ts = salary + perks;
            return ts;
        }
    }
    public class Manager : Employee
    {
        public override double GetPerks(float salary, float perks)
        {
            return base.GetPerks(salary, perks) * 1.10;
           // double ts = 1.10 * (Salary + perks);
            //return ts;
        }
    }
}
