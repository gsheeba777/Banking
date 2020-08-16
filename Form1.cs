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

namespace BankingWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConString = "Data Source=./LAPTOP-FAO2P8J8/SQLEXPRESS;Initial Catalog=BankingSystem.mdf;Integrated Security=true";
                SqlConnection connection = new SqlConnection(MyConString);
                string cmdText = "INSERT INTO account(accid ,acctype ,balance ,description)VALUES ('" + txtcustid.Text + "','" + txtacctype.Text + "','" + txtcustbal.Text + "','" + txtcustadrs.Text + "')";
                SqlCommand cmd = new SqlCommand(cmdText, connection);

                connection.Open();

                int result = cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("suscess");

            }
            catch (Exception ex)
            {
                // Console.Write("not entered");
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcustid.Text = "";
            txtacctype.Text = "";
            txtcustbal.Text = "";
            txtcustadrs.Text = "";
        }
    }

       
    }

