using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingWindowsApplication
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fundtransfer ft = new fundtransfer();
            ft.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountDetails ad = new AccountDetails();
            ad.Show();
        }
    }
}
