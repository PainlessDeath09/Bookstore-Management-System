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
        public static String username;
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUserName()
        {
            con.Open();
            String syntax = "SELECT Value from systemTable where Property = 'UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private String getPassword()
        {
            con.Open();
            String syntax = "SELECT Value from systemTable where Property = 'Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String user = getUserName();
            String pass = getPassword();

            if(user.Equals(textBox1.Text) && pass.Equals(textBox2.Text))
            {
                MessageBox.Show("Login Succcess");
                AppBody ob = new AppBody();
                this.Hide();
                ob.Show();
                username = user;
                
            }
            else
            {
                MessageBox.Show("Login Unsuccessful");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
