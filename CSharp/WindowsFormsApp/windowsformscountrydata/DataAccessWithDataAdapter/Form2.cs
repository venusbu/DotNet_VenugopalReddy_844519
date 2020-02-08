using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccessWithDataAdapter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        string conString, qryString;

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select * from Customers where Country='" + cmbCountries.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "CustomerInfo");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "CustomerInfo";
        }

        private void btnCustomersOrders_Click(object sender, EventArgs e)
        {
            qryString = "select " +
                "c.CustomerID, c.CompanyName,c.ContactName,o.OrderId,o.OrderDate,o.ShippedDate from Customers c JOIN Orders o ON O.CustomerID  = c.CustomerID";
            sqlcmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "join");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "join";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qryString = "select p.ProductID, p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p JOIN Categories c ON p.ProductID = c.CategoryID";

            sqlcmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "join");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "join";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qryString = "select count(OrderID) from Orders";
            sqlCon.Open();
            sqlcmd = new SqlCommand(qryString, sqlCon);
            var d = sqlcmd.ExecuteScalar().ToString();
            MessageBox.Show(d, "Total Orders");
            sqlCon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qryString = "Select ProductID, ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            using (sqlCon = new SqlConnection(conString))
            {
                sqlcmd = new SqlCommand(qryString, sqlCon);
                da = new SqlDataAdapter(sqlcmd);
                ds.Clear();
                da.Fill(ds, "ProductsInfo");

                DataTable dt = ds.Tables["ProductsInfo"];
                var products = from product in dt.AsEnumerable()
                               where product.Field<decimal>("UnitPrice") >=50
                               select new
                               {
                                   ProdID = product["ProductID"],
                                   ProdName = product["ProductName"],
                                   Price = product["UnitPrice"],
                                   Quantity = product["QuantityPerUnit"]
                               };
                foreach (var product in products)
                {
                    MessageBox.Show("ProductID=" + product.ProdID + "Name" + product.ProdName + "Price = " + product.Price + "Quantity=" + product.Quantity, "Products with Price<50.00");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
            qryString = "select Country from Customers";
            sqlCon.Open();
            sqlcmd = new SqlCommand(qryString, sqlCon);
            ds.Clear();
            da = new SqlDataAdapter(sqlcmd);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCountries.Items.Add(dr["Country"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
