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

namespace DataAcessAppProg
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
        string conString, qryString;

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            //propulating the combobox with all the products
            sqlCon.Open();
            qryString = "Select ProductName from Products";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();

            while(dr.Read())
            {
                cmbProducts.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();

            cmbProducts.Text = "All Products";
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select UnitPrice from Products where ProductName ='" + cmbProducts.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();
            label1.Text = "Unit Price:" + sqlcmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            qryString = "Select ProductName from Products";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();

            while(dr.Read())
            {
                listBox1.Items.Add(dr["ProductName"]);
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
