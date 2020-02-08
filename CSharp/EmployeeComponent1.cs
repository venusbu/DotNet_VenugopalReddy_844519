using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeComponent;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmployeID = 10, Empname = "venu", DeptId = 078 };

          var c=  emp.ShowData();

            var salary = emp.GetSalary(30, 800);
            var incent = emp.GetIncentives(salary);

            var tSalary = salary + incent;
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
