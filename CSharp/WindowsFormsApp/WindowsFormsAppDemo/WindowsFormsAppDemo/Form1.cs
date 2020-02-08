using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("good morning");

            if ((textFirst.Text == "")  ||  (textSecond.Text == ""))
            {
                MessageBox.Show("Fields cannot be blank, Enter data", "Input Data");
            }
            else
            {
                double n1, n2;
                n1 = double.Parse(textFirst.Text);
                n2 = double.Parse(textSecond.Text);

                double result = 0;

                if(rdbAdd.Checked)
                {
                    result = (n1 + n2);
                    lblSolution.Text = "Sum:" + result;
                }
                else if (rdbsub.Checked)
                {
                    result = (n1 - n2);
                    lblSolution.Text = "Difference:" + result;
                }
                else if (rdbmul.Checked)
                {
                    result = (n1 * n2);
                    lblSolution.Text = "Product:" + result;
                }
                else if (rdbdiv.Checked)
                {
                    result = (n1 / n2);
                    lblSolution.Text = "Quotient" + result;
                }
                else
                    lblSolution.Text = "Enter your Choice First";
            }
        }
    }
}
