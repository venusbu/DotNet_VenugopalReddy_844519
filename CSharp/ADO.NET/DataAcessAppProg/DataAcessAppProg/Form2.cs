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
    public partial class Form2 : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        string conString, qryString;

        public Form2()
        {
            InitializeComponent();
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            // sqlCon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "GetCustomersByCountry";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = sqlCon;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@country";
            param.DbType = DbType.String;
            param.Value = cmbCountries.Text;

            sqlcmd.Parameters.Add(param);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "CustomersByCountry");

            gvCustomers.DataSource = ds;
            gvCustomers.DataMember = "CustomersByCountry";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source=BLT10140\\SQLEXPRESS2014;Initial Catalog=Northwind;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            ds = new DataSet();

            using (sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                qryString = "Select distinct Country from Customers";
                sqlcmd = new SqlCommand(qryString, sqlCon);
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
}
