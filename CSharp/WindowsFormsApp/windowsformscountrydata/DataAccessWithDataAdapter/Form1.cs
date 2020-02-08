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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        string conString, qryString;

        private void button1_Click(object sender, EventArgs e)
        {
            qryString = "select ProductID, ProductName,UnitPrice,QuantityPerUnit,CategoryID from Products";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            da = new SqlDataAdapter(sqlcmd);
            // ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "ProductInfo");
            gvProducts.DataSource = ds;
            gvProducts.DataMember = "ProductInfo";

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
          
            qryString = "Select * from Categories";
            sqlcmd = new SqlCommand(qryString, sqlCon);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "CategoriesInfo");

            gvProducts.DataSource = ds;
            gvProducts.DataMember = "CategoriesInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();
        }
    }
}
