using Guna.UI.Animation;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_page_HMS_
{
    public partial class Receptionist : Form
    {
        int Key = 0;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HMS(Login);Integrated Security=True");
        public Receptionist()
        {
            InitializeComponent();
            DisplayRec();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(100, 85, 100, 85);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void DisplayRec()
        {
            con.Open();
            string query = "Select * from Recept";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RecpId.Text) || string.IsNullOrWhiteSpace(RescpName.Text) || string.IsNullOrWhiteSpace(Age.Text) || string.IsNullOrWhiteSpace(Contact.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(CompleteInfo.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Insert into  Recept (RecpId, RescpName, Age, Contact, Password, CompleteInfo) Values (@RecpId, @RescpName, @Age, @Contact, @Password, @CompleteInfo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@RecpId", RecpId.Text);
                    cmd.Parameters.AddWithValue("RescpName", RescpName.Text);
                    cmd.Parameters.AddWithValue("@Age", Age.Text);
                    cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.Parameters.AddWithValue("@CompleteInfo", CompleteInfo.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Add Sucessfully..........");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePage hop = new HomePage();
            hop.Show();
            this.Hide();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RecpId.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            RescpName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Age.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Contact.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Password.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            CompleteInfo.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
           // flag = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RecpId.Text) || string.IsNullOrWhiteSpace(RescpName.Text) || string.IsNullOrWhiteSpace(Age.Text) || string.IsNullOrWhiteSpace(Contact.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(CompleteInfo.Text))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Update Recept set RescpName=@RescpName, Age=@Age, Contact=@Contact, Password=@Password, CompleteInfo=@CompleteInfo where RecpId=@RecpId";
                    SqlCommand cmd = new SqlCommand(query, con);    
                    cmd.Parameters.AddWithValue("RescpName", RescpName.Text);
                    cmd.Parameters.AddWithValue("@Age", Age.Text);
                    cmd.Parameters.AddWithValue("@Contact", Contact.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.Parameters.AddWithValue("@CompleteInfo", CompleteInfo.Text);
                    cmd.Parameters.AddWithValue("@RecpId", RecpId.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Add Sucessfully..........");
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
            if (string.IsNullOrWhiteSpace(RecpId.Text))
            {
                MessageBox.Show("Fill the Information........");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Recept WHERE RecpId = @RecpId"; // Corrected parameter name
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@RecpId", RecpId.Text); // Use the correct parameter name here
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Receptionist Record....");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage hom = new HomePage();
            hom.Show();
            this.Hide();
        }
    }
}
