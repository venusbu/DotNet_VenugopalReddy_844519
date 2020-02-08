using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace CodeFirstprogramDemosql
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerDBContext context = new CustomerDBContext();

            //var orders = context.Orders;

            //var order4 = new Order() { OrderID = 1, OrderDate = new DateTime(2020, 01, 01), CustomerID = 1, ShippedDate = new DateTime(2020, 01, 15) };

            //var order5 = new Order() { OrderID = 2, OrderDate = new DateTime(2020, 01, 10), CustomerID = 2, ShippedDate = new DateTime(2020, 01, 25) };
            //context.Orders.Add(order4);
            //context.Orders.Add(order5);
            //context.SaveChanges();   //Database gets into the database
        }
    }
        public class CustomerDBContext : DbContext
        {
            public CustomerDBContext() :
                base("name=CustomerDBContext")
            { }
        
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Order> Orders { get; set; }
        }
        public class Customer
        {
            public int CustomerID { get; set; }

            public string Name { get; set; }

            public string Address { get; set; }

            public string Country { get; set; }

        }

        public class Order
        {
            public int OrderID { get; set; }

            public DateTime ODate { get; set; }

            public int CustomerID { get; set; }

            public DateTime ShippedDate { get; set; }
        }
    
}
