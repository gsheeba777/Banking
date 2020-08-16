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
using System.Data.Sql;

namespace BankingWindowsApplication
{
    public partial class fundtransfer : Form
    {
        public fundtransfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fno, tono;
            double bal;

            fno = textBox1.Text;
            tono = textBox2.Text;
            bal = double.Parse(textBox3.Text);

            string MyConString = "Data Source=./LAPTOP-FAO2P8J8/SQLEXPRESS;Initial Catalog=BankingSystem.mdf;Integrated Security=true";
            SqlConnection connection = new SqlConnection(MyConString);

            connection.Open();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction;
            transaction = connection.BeginTransaction();
            cmd.Connection = connection;
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandText = "update account set balance = balance - '" + bal + "' where accid ='" + fno + "'";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update account set balance = balance + '" + bal + "' where accid ='" + tono + "'";
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Sucessfully Transfferred..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
