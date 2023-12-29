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

namespace Login_page_HMS_
{
    public partial class Patient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HMS(Login);Integrated Security=True");
        public Patient()
        {
            InitializeComponent();
            Display();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientId.Text) ||
      string.IsNullOrWhiteSpace(PatientName.Text) ||
      string.IsNullOrWhiteSpace(Gender.Text) ||
      string.IsNullOrWhiteSpace(DOB.Text) ||
      string.IsNullOrWhiteSpace(HIV.Text) ||
      string.IsNullOrWhiteSpace(Contactno.Text) ||
      string.IsNullOrWhiteSpace(Allgeries.Text) ||
      string.IsNullOrWhiteSpace(Address.Text) ||
      (Address.SelectedValue == null) ||  // Check if Address.SelectedValue is null
      string.IsNullOrWhiteSpace(Address.SelectedValue.ToString()))
            {
                MessageBox.Show("Missing Information......");
            }

            else
            {
                try
                {
                    DateTime dob = DateTime.Parse(DOB.Text); // Assuming DOB.Text contains the date in a recognizable format

                    // Convert DateTime to string in a specific format that SQL accepts (assuming SQL Server)
                    string dobString = dob.ToString("yyyy-MM-dd"); // This format is compatible with SQL Server

                    con.Open();
                    string query = "Insert into  Pat (PatientId, PatientName, Gender, DOB, HIV, Contactno, Allgeries, Address) Values (@PatientId, @PatientName, @Gender, @DOB, @HIV, @Contactno, @Allgeries, @Address)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PatientId", PatientId.Text);
                    cmd.Parameters.AddWithValue("@PatientName", PatientName.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                    cmd.Parameters.AddWithValue("@DOB", dobString);
                    cmd.Parameters.AddWithValue("@HIV", HIV.Text);
                    cmd.Parameters.AddWithValue("@Contactno", Contactno.Text);
                    cmd.Parameters.AddWithValue("@Allgeries", Allgeries.Text);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Add Sucessfully..........");
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Display()
        {

            con.Open();
            string query = "Select * from  Pat";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
            if (gunaDataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                PatientId.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            PatientName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Gender.SelectedValue = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DOB.Text = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            HIV.SelectedValue = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Contactno.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Allgeries.Text = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Address.Text = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientId.Text) || string.IsNullOrWhiteSpace(PatientName.Text) || string.IsNullOrWhiteSpace(Gender.Text) || string.IsNullOrWhiteSpace(DOB.Text) || string.IsNullOrWhiteSpace(HIV.Text) || string.IsNullOrWhiteSpace(Contactno.Text) || string.IsNullOrWhiteSpace(Allgeries.Text) || string.IsNullOrWhiteSpace(Address.Text) || string.IsNullOrWhiteSpace(Address.SelectedValue.ToString()))
            {
                MessageBox.Show("Missing Information......");
            }
            else
            {
                try
                {
                    DateTime dob = DateTime.Parse(DOB.Text); // Assuming DOB.Text contains the date in a recognizable format

                    // Convert DateTime to string in a specific format that SQL accepts (assuming SQL Server)
                    string dobString = dob.ToString("yyyy-MM-dd"); // This format is compatible with SQL Server

                    con.Open();
                    string query = "Update Pat set PatientName=@PatientName, Gender=@Gender, DOB=@DOB, HIV=@HIV, Contactno=@Contactno, Allgeries=@Allgeries, Address=@Address where PatientId=@PatientId";
                    SqlCommand cmd = new SqlCommand(query, con);                  
                    cmd.Parameters.AddWithValue("@PatientName", PatientName.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                    cmd.Parameters.AddWithValue("@DOB", dobString);
                    cmd.Parameters.AddWithValue("@HIV", HIV.Text);
                    cmd.Parameters.AddWithValue("@Contactno", Contactno.Text);
                    cmd.Parameters.AddWithValue("@Allgeries", Allgeries.Text);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
                    cmd.Parameters.AddWithValue("@PatientId", PatientId.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Information Update Sucessfully..........");
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PatientId.Text))
            {
                MessageBox.Show("Missing Information.......");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Delete from Pat where PatientId=@PatientId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PatientId", PatientId.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Infromation........");
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PATIENT DATA FORMS", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.DarkRed, new Point(230));
            e.Graphics.DrawString("PatientID: " + gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 70));
            e.Graphics.DrawString("PatientName: " + gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 100));
            e.Graphics.DrawString("Gender: " + gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 130));
            e.Graphics.DrawString("DOB: " + gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 160));
            e.Graphics.DrawString("HIV: " + gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 190));
            e.Graphics.DrawString("Contactno: " + gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 220));
            e.Graphics.DrawString("Allgeries: " + gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 250));
            e.Graphics.DrawString("Address: " + gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(100, 280));
        }
        int flag = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
