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

namespace Bookstore_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void getData()
        {
            con.Open();
            String syntax = "SELECT Value from systemTable where Property = 'UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show(""+dr[0].ToString());

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            getData();
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
