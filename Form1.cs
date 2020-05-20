using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;

            if(user.Equals("admin") && pass.Equals("123"))
            {
                MessageBox.Show("Login Succcess");
            }
            else
            {
                MessageBox.Show("Login Unsuccessful");
            }
        }
    }
}
