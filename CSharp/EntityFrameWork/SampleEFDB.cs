using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEFDBEntities_program
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();

            //var employee54 = new Employee()
            //{
            //    EmpID = 46,
            //    Name = "Andrew Trolesa",
            //    Salary = 35000,
            //    SSN = 234568,
            //    DeptID = 3
            //};
            //context.Employees.Add(employee54);
            //context.SaveChanges();

            //var employee16 = new Employee()
            //{
            //    EmpID = 47,
            //    Name = "Vujdddfjgyfj",
            //    Salary = 2126,
            //    SSN = 2122,
            //    DeptID = 3
            //};
            //context.Employees.Add(employee16);
            //context.SaveChanges();
            //LinqToEntity();
            //ModifyEmployee();
            DeleteEmployee();
        }
        public static void LinqToEntity()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;
            var emplist = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in emplist)
            {
                Console.WriteLine("EmpID: {0}, Name: {1}, Salary: {2},SSN: {3}",
                    emp.EmpID, emp.Name, emp.Salary, emp.SSN);
            }
        }
        public static void ModifyEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;

            var emplist = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in emplist)
            {
                if (emp.EmpID == 1)
                    emp.Name = "Mathew McDonald";
            }
            context.SaveChanges();
        }
            public static void DeleteEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;

            var employee = new Employee { EmpID = 4 };
            employees.Attach(employee);
            employees.Remove(employee);
            context.SaveChanges();
        }

    }
}

