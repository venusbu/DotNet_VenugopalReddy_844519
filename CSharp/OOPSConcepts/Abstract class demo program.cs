using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_demo_program
{
    class Program
    {
        static void Main(string[] args)
        {
            SBAccount objSB = new SBAccount();
            CCAccount objCC = new CCAccount();

            double siSB = objSB.GetSimpleIntrest(56000.00, 4, 7);
            double tamt = objSB.GetTotalAmount(5000.00, siSB);

            Console.WriteLine("SimpleItrest(Savings Bank): Rs {0}", siSB);
            Console.WriteLine("Total Amount: Rs {0}", tamt);

            var siCC = objCC.GetSimpleIntrest(9500.00, 5, 8);
            tamt = objCC.GetTotalAmount(50000.00, siCC);

            Console.WriteLine("SimpleItrest(Current Account): Rs {0}", siCC);
            Console.WriteLine("Total Amount: Rs {0}", tamt);

            objSB.show();
        }
    }
    public abstract class banking
    {
        public abstract double GetSimpleIntrest(double pr, int td, short rt);
        public abstract double GetTotalAmount(double bal, double si);

        public void show()
        {
            Console.WriteLine("This is concrete method defined within abstract class");

        }
    }
    public class SBAccount : banking
    {
        public override double GetSimpleIntrest(double pr, int td, short rt)
        {
            double si = 0.25 * ((pr * td * rt) / 100);
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
    public class CCAccount : banking
    {
        public override double GetSimpleIntrest(double pr, int td, short rt)
        {
            double si = 0.25 * ((pr + td + rt) / 100);
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
}
