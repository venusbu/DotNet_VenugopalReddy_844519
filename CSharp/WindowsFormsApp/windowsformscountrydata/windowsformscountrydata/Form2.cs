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

namespace windowsformscountrydata
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
        string conString, qryString;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "Select UnitPrice from Products where ProductName ='" + comboBox1.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();
            txtPrice.Text = "Price:" + sqlcmd.ExecuteScalar().ToString();
            sqlCon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            qryString = "Update Products Set UnitPrice = " +textBox1.Text
                + " Where ProductName = '" + comboBox1.Text + "'";

            sqlcmd = new SqlCommand(qryString, sqlCon);
            sqlCon.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated", "New Product Price:");

            sqlCon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);

            sqlCon.Open();
           // qryString = "Select ProductName from Products";

            sqlcmd = new SqlCommand("Select ProductName from Products", sqlCon);
            dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ProductName"])
            }
            dr.Close();
            sqlCon.Close();
        }
    }
}
