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
using Guna.UI.WinForms;
using System.Net;

namespace Login_page_HMS_
{
    public partial class Labotory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HMS(Login);Integrated Security=True");   
        public Labotory()
        {
            InitializeComponent();
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(100, 85, 100, 85);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TestId.Text) || string.IsNullOrWhiteSpace(TestName.Text) || string.IsNullOrWhiteSpace(Cost.Text))
            {
                MessageBox.Show("Missing Information.......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert Lab (TestId, TestName, Cost) values (@TestId, @TestName, @Cost)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TestId", TestId.Text);
                    cmd.Parameters.AddWithValue("@TestName", TestName.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Added Sucessfully......");
                    DisplayRec();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DisplayRec()
        {
            con.Open();
            string query = "Select * from Lab";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage hom = new HomePage();
            hom.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TestId.Text) || string.IsNullOrWhiteSpace(TestName.Text) || string.IsNullOrWhiteSpace(Cost.Text))
            {
                MessageBox.Show("Missing Information.......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Lab set TestName=@TestName, Cost=@Cost where TestId=@TestId ";
                    SqlCommand cmd = new SqlCommand(query, con);                 
                    cmd.Parameters.AddWithValue("@TestName", TestName.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost.Text);
                    cmd.Parameters.AddWithValue("@TestId", TestId.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Update Sucessfully......");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TestId.Text))
            {
                MessageBox.Show("Missing Information.......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Delete from Lab where TestId=@TestId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TestId", TestId.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Infromation........");
                    DisplayRec();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TestId.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TestName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Cost.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
