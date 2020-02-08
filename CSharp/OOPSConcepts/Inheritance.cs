using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanceexamplebyvenu
{
    class inheri : vehicle
    {
        static void Main(string[] args)
        {
            inheri obj = new inheri();
            obj.mode();
            obj.feature();
            obj.Noise();
            string sr = "hello world";
            sr.Reverse();
            
            Console.Read();
        }
        public void Noise()
        {
            Console.WriteLine("All Vehicles Creates Noise !! ");
        }
    }
    
    class vehicle : Mode
    {

        public void feature()
        {
            Console.WriteLine("They Mainly Help in Travelling !!");
        }
    }
    class Mode
    {
        public void mode()
        {
            Console.WriteLine("There are Many Modes of Transport !!");
        }
    }
}
