using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(1,"Robert", 1515,"Admin" );
            Employee emp2 = new Employee(2,"Venu", 1324,"Technical");

            emp1.ShowData();
            emp2.ShowData();
        
        }
    }
    public class Employee
    {
        int empid;
        string empname;
        short deptid;
        string deptname;
        public Employee()
        { }
        public Employee(int eid,string ename,short did,string dname) //constructor with 4 parameters
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }
        public void ShowData()
        {
            Console.WriteLine("EmpID = {0}", empid);
            Console.WriteLine("EmpName = {0}", empname);
            Console.WriteLine("DeptID = {0}", deptid);
            Console.WriteLine("DeptName = {0}", deptname);
        }
    }
}
