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
    public partial class AccountDetails : Form
    {
        public AccountDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MyConString = "Data Source=./LAPTOP-FAO2P8J8/SQLEXPRESS;Initial Catalog=BankingSystem.mdf;Integrated Security=true";
            SqlConnection connection = new SqlConnection(MyConString);

            connection.Open();

            string str = "select * from account where accid = '" + textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(str, connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGridView1.DataBind();
        }
    }
}
