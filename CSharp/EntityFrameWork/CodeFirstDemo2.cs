using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemoProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBContext Context = new EmployeeDBContext();

            var employee = Context.Employees;

            var Employee1 = employee.Add(new Employee()
            {
                EmployeeID = 4,
                Name = "Venu reddy",
                Salary = 30000
            });
            var Employee2 = employee.Add(new Employee()
            {
                EmployeeID = 4,
                Name = "Venu",
                Salary = 30000
            });
            var Employee3 = employee.Add(new Employee()
            {
                EmployeeID = 4,
                Name = "Venu gopal",
                Salary = 30000
            });
            Context.SaveChanges();
        }
    }
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() :
            base("name=EmployeeDBContext")
        { }

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Category> Categories { get; set; }
    }
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
    }
}