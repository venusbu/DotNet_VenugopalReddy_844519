using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    class Program
    {
        static SqlConnection sqlCon;
        static SqlCommand sqlcmd;
        static SqlDataReader dr;
        static DataSet ds;
        static SqlDataAdapter da;
        static string conString, qryString;

        static void Main(string[] args)
        {

            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            qryString = "select ProductID,ProductName from Products";
            sqlCon.Open();
            sqlcmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlcmd);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProductID:{0},ProductName:{1}", dr["ProductID"], dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();

            LINQToDataSets();
        }
        public static void LINQToDataSets()
        {
            qryString = "select CustomerId, CompanyName,ContactName,Adress,Country from Customers";
            using (sqlCon = new SqlConnection(conString))
            {
                da = new SqlDataAdapter(sqlcmd);
                ds = new DataSet();
                da.Fill(ds, "CustomerInfo");

                DataTable dtCustomers = ds.Tables["CustomersInfo"];
                var specificCustomers = from customer in dtCustomers.AsEnumerable()
                                        where customer.Field<string>("Country") == "UK"
                                        select new
                                        {
                                            custID = customer["ProductID"],
                                            companyName = customer["ProductName"],
                                            contactName = customer["Co"],
                                            address = customer["Address"],
                                            country = customer["Country"]
                                        };
                foreach(var customer in specificCustomers)
                {
                    Console.WriteLine("\n\nCustomerID: {0}", customer.custID);
                    Console.WriteLine("\n\nName: {0}", customer.contactName);
                    Console.WriteLine("\n\nCompanyName: {0}", customer.companyName);
                    Console.WriteLine("\n\nAddress: {0}", customer.address);
                    Console.WriteLine("\n\nCountry: {0}", customer.country);
                }
            }
        }
    }

    internal class SqlDataSet
    {
    }
}
