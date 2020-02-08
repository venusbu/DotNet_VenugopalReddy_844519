using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace genericsCollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100);

            items.Add("Hello World");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object obj in items)
                Console.WriteLine(obj.ToString());

            List<int> myInts = new List<int>();

            myInts.Add(10);
            myInts.Add(80);
            //myTnts.Add("H1");
            myInts.Add(90);

            foreach (var n in myInts)
                Console.WriteLine(n.ToString());


            List<string> employee = new List<string>() { "vicky ", "venu", "milan", "kowshik", "praveen" };
            foreach (var emp in employee)
            {
                Console.WriteLine(emp);
            }
            Dictionary<int, string> fruit = new Dictionary<int, string>();
            fruit.Add(1, "Banana");
            fruit.Add(2, "Orange");
            fruit.Add(3, "Mango");
            fruit.Add(4, "Pomogranate");
            fruit.Remove(4);
            fruit.Add(4, "grapes");

            foreach (KeyValuePair<int, string> kv in fruit)
            {
                Console.WriteLine("Key -> {0}, Value -> {1}", kv.Key, kv.Value);
            }

            SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();

            gadgets.Add(3, "Thinkpad");
            gadgets.Add(1, "NotePad");
            gadgets.Add(5, "SmartPhone");
            gadgets.Add(4, "CDPhone");
            gadgets.Add(2, "CDMicrophone");

            foreach (KeyValuePair<int, string> k in gadgets)
            {
                Console.WriteLine("Key -> {0}, Value -> {1}", k.Key, k.Value);

            }
   
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee() { EmployeeID = 1, EmpName = "venu", Department = "Cognizant CEO" });
            Employees.Add(new Employee() { EmployeeID = 2, EmpName = "milan", Department = "Cognizant TL" });
            Employees.Add(new Employee() { EmployeeID = 3, EmpName = "vignesh", Department = "Cognizant HR" });

            foreach (var emp in Employees)
            {
                Console.WriteLine("EmpID = {0}, Name = {1}, Department = {2}", emp.EmployeeID, emp.EmpName, emp.Department);
            }

            Console.WriteLine("\nAfter calling the Pop method");
            foreach (var fn in fnumbers)
                Console.WriteLine(fn)
            foreach(var qn in qnumbers)
            Console.ReadKey();
        }

        public class Employee
        {
            public int EmployeeID
            {
                get; set;
            }
            public string EmpName
            {
                get;
                set;
            }
            public string Department
            {
                get;
                set;
            }
            public string ShowData()
            {
                return string.Format("EmpID:{0}, EmpName:{1}, Department:{2}", EmployeeID, EmpName, Department);
            }
        }
    }
}
