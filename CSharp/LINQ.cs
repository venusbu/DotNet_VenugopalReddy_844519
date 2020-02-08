using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "milan", "venu", "vignesh", "kowshik", "praveen", "sairam" };

            var KnownEmpls = from emp in employees
                             where emp.StartsWith("v")
                             select emp;

            foreach (string emp in KnownEmpls)
            {
                Console.WriteLine("Empname starts with v: {0}", emp);
            }

            //using Method syntax
            // => is known as Lambda operator, and is read as 'goes to'
            var someEmpls = employees.Where(s => s.Contains("p"));

            foreach (string emp in someEmpls)
            {
                Console.WriteLine("Empname starts with p: {0}", emp);
            }

            Console.WriteLine("******************************");

            List<string> fruits = new List<string>() { "Apple", "Orange", "Grapes", "Pineapple", "Banana", "Watermelon" };

            var fruitswitchP = from fruit in fruits
                               where fruit.Contains("p")
                               select fruit;

            foreach (string fruit in fruitswitchP)
            {
                Console.WriteLine("Fruit with letter p: {0}", fruit);
            }

            var largeNameFruits = from fruit in fruits
                                  where fruit.Length > 6
                                  select fruit;

            foreach (string fruit in largeNameFruits)
            {
                Console.WriteLine("Larger name fruit: {0}", fruit);
            }
            Console.WriteLine("*********************************************");
            //using Method syntax
            var smallerNameFruits = fruits.Where(fruit => fruit.Length <= 6);

            foreach (string fruit in smallerNameFruits)
            {
                Console.WriteLine("smaller name fruit:{0}", fruit);
            }
            Console.WriteLine("*********************************************");

            int[] marks = new int[6] { 98, 86, 89, 80, 94, 93 };
            var highMarks = from m in marks
                            where m > 90
                            select m;
            foreach (var m in highMarks)
            {
                Console.WriteLine("High marks: {0}", m);
            }

            Console.WriteLine("*********************************************");

            var marksInDOrder = from m in marks
                                orderby m descending
                                select m;

            foreach (var m in marksInDOrder)
            {
                Console.WriteLine("Marks in D order: {0}", m);
            }
            Console.WriteLine("*********************************************");

            var marksInorder = marks.OrderBy(m => m);
            foreach (var m in marksInorder)
            {
                Console.WriteLine("Marks in order: {0}", m);
            }
            Console.WriteLine("***********************************************");

            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee() { EmpId = 1, EmpName = "Venu Gopal" });
            Employees.Add(new Employee() { EmpId = 2, EmpName = "VenuGopal Reddy" });
            Employees.Add(new Employee() { EmpId = 3, EmpName = "Milan" });

            var proEmpls = from emp in Employees
                           where emp.EmpName.Contains("V")
                           select emp;
            foreach (var emp in proEmpls)
            {
                Console.WriteLine("Emp Name: {0}, Emp Id:{1}", emp.EmpName, emp.EmpId);
            }
            Console.WriteLine("***********************************************");

            List<Teacher> Teachers = new List<Teacher>()
            {
                new Teacher { ID =1,FirstName="Venugopal", LastName ="Reddy", City = "Seattle" },
                new Teacher { ID =1,FirstName="Milan", LastName ="Mathew", City = "Redmond" },
                new Teacher { ID =1,FirstName="Vig", LastName ="nesh", City = "Lake" }
            };

            List<Student> Students = new List<Student>()
            {
                new Student { ID =1,FirstName="Kowshik", LastName ="Bezawada", City = "Redmond" },
                new Student { ID =1,FirstName="Praveen", LastName ="Mathu", City = "Seattle" },
                new Student { ID =1,FirstName="Sai", LastName ="Ram", City = "Lake" },
            };

            var peopleInSeattle = (from teacher in Teachers
                                   where teacher.City == "Seattle"
                                   select teacher.FirstName).
                                  Concat(from student in Students
                                         where student.City == "Seattle"
                                         select student.FirstName);
            foreach (var person in peopleInSeattle)
            {
                Console.WriteLine("From Seattle City: {0}", person);
            }
            Console.ReadLine();
        }
        public class Employee
        {
            public int EmpId
            {
                get;
                set;
            }
            public string EmpName
            {
                get;
                set;
            }

        }
        class Teacher
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
        class Student
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
