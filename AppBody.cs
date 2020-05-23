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
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");

        private void AppBody_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void refreshDataView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllBooksData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL ERROR \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL ERROR \n" + ex);
            }
        }

        

        private void add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("AddBooks_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", accno_textbox.Text);
            cmd.Parameters.AddWithValue("@isbn", isbn_textbox.Text);
            cmd.Parameters.AddWithValue("@name", name_textbox.Text);
            cmd.Parameters.AddWithValue("@author", author_textbox.Text); 
            cmd.Parameters.AddWithValue("@publisher", pub_textbox.Text);
            cmd.Parameters.AddWithValue("@dId", did.Text);
            con.Open();
             
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("SQL ERROR \n" + ex);
            }
            con.Close();

            refreshDataView();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            refreshDataView();
        }
    }
}
