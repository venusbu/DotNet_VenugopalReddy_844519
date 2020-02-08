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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string conString, qryString;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            qryString = "Select ContactName from Customers where Country ='" + cmb1.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();
            dr = sqlcmd.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr["ContactName"]);
            }
          
            sqlCon.Close();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            //propulating the combobox with all the products
            sqlCon.Open();
            qryString = "Select distinct Country from Customers";
            sqlcmd = new SqlCommand(qryString, sqlCon);

            dr = sqlcmd.ExecuteReader();

            while (dr.Read())
                {
                    cmb1.Items.Add(dr["Country"]);
                }
            dr.Close();
            sqlCon.Close();

           
        }

    }
}

