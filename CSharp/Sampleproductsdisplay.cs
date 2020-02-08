using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp14sampleproductsdisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlCon;
            SqlCommand sqlCmd;
            SqlDataAdapter da;
            SqlDataReader dr;
           // DataSet ds;
            string conString, qryString;

            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";

            sqlCon = new SqlConnection(conString);
            qryString = "select ProductID, ProductName, QuantityPerUnit from Products";
            sqlCon.Open();
            sqlCmd = new SqlCommand(qryString, sqlCon);
          //  da = new SqlDataAdapter(sqlCmd);
            dr = sqlCmd.ExecuteReader();
           // ds = new DataSet();
            while (dr.Read())
            {
                Console.WriteLine("ProductID: {0}, ProductName: {1}, QunatityPerUnit: {2}", dr["ProductID"], dr["ProductName"], dr["QuantityPerUnit"].ToString());
            }
            dr.Close();
            sqlCon.Close();


        }
    }
}
