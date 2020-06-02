using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            Application.Exit();
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
            cmd.Parameters.AddWithValue("@price", bookPrice.Text);
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

            refreshDataView();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchBook_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", textBox1.Text);

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

        private void refreshStats()
        {
            con.Open();
            String count = "SELECT COUNT(*) FROM books";
            String averg = "SELECT AVG(price) FROM books";
            String minimum = "SELECT MIN(price) FROM books";
            String maximum = "SELECT MAX(price) FROM books";

            SqlCommand cmd = new SqlCommand(count, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            noBooks.Text = dr[0].ToString();
            noBooks.Visible = true;
            con.Close();

            con.Open();
            cmd = new SqlCommand(averg, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            avg.Text = dr[0].ToString();
            avg.Visible = true;
            con.Close();

            con.Open();
            cmd = new SqlCommand(minimum, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            min.Text = dr[0].ToString();
            min.Visible = true;
            con.Close();

            con.Open();
            cmd = new SqlCommand(maximum, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            max.Text = dr[0].ToString();
            max.Visible = true;
            con.Close();


        }


        private void AppBody_Load(object sender, EventArgs e)
        {
            refreshDataView();
            memResult.Visible = false;
            memResult2.Visible = false;
            bookResult.Visible = false;
            noBooks.Visible = false;
            min.Visible = false;
            avg.Visible = false;
            max.Visible = false;
            refreshStats();

        }

        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BooksDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", accno_textbox.Text);
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

                refreshDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL ERROR \n" + ex);
            }
        }

        private void clr_Click(object sender, EventArgs e)
        {
            refreshDataView();
            textBox1.Clear();
            name_textbox.Clear();
            accno_textbox.Clear();
            pub_textbox.Clear();
            did.Clear();
            author_textbox.Clear();
            isbn_textbox.Clear();
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("MakePurchase_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@memID", mID.Text);
            cmd.Parameters.AddWithValue("@Book1", b1.Text);
            cmd.Parameters.AddWithValue("@Book2", b2.Text);
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

            //INSERTION LOG
            cmd = new SqlCommand("TransactionsInsert_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mem_ID", mID.Text);
            cmd.Parameters.AddWithValue("@bookno", b1.Text);
            cmd.Parameters.AddWithValue("@bookno2", b2.Text);
            cmd.Parameters.AddWithValue("@Authorized_By", Form1.username);
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

            MessageBox.Show("Purchase Complete");


        }

        private void mem_Search_Click(object sender, EventArgs e)
        {
            con.Open();
            String syntax = "SELECT Book1 from members where m_ID = '" + memId.Text + "'";
            SqlCommand cmd = new SqlCommand(syntax, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            memResult.Text = "Book1= " + dr[0].ToString();
            memResult.Visible = true;
            con.Close();

            con.Open();
            syntax = "SELECT Book2 from members where m_ID = '" + memId.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            memResult2.Text = "Book2= " + dr[0].ToString();
            memResult2.Visible = true;
            con.Close();
        }

        private void bookACC_Search_Click(object sender, EventArgs e)
        {
            bookResult.Text = "";
            con.Open();
            String syntax = "SELECT m_ID from members where Book1 = '" + BookID.Text + "'";
            SqlCommand cmd = new SqlCommand(syntax, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
                bookResult.Text = BookID.Text + " has been bought by = \n" + dr[0].ToString();

            //bookResult.Visible = true;
            con.Close();

            con.Open();
            syntax = "SELECT m_ID from members where Book2 = '" + BookID.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
                if (bookResult.Text == "")
                    bookResult.Text = BookID.Text + " has been bought by = \n" + dr[0].ToString();
                else
                    bookResult.Text = bookResult.Text + "\n" + dr[0].ToString();
            bookResult.Visible = true;
            con.Close();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            memResult.Visible = false;
            memResult2.Visible = false;
            bookResult.Visible = false;
            memId.Clear();
            BookID.Clear();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllLog", con);
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

                logDataGrid.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL ERROR \n" + ex);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshStats();
        }
    }
}
