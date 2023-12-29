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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI.WinForms;

namespace Login_page_HMS_
{
    public partial class Doctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HMS(Login);Integrated Security=True");
        public Doctor()
        {
            InitializeComponent();
            DisplayRec();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorId.Text) || string.IsNullOrWhiteSpace(DoctorName.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(DOB.Text) || string.IsNullOrWhiteSpace(Gender.Text) || string.IsNullOrWhiteSpace(Specialiest.Text) || string.IsNullOrWhiteSpace(Experience.Text) || string.IsNullOrWhiteSpace(Contactno.Text) || string.IsNullOrWhiteSpace(Address.Text))
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
                    string query = "Insert into  Docto (DoctorId, DoctorName, Password, Gender, DOB, Specialiest, Experience, Contactno, Address) Values (@DoctorId, @DoctorName, @Password, @Gender, @DOB, @Specialiest, @Experience, @Contactno, @Address)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DoctorId", DoctorId.Text);
                    cmd.Parameters.AddWithValue("@DoctorName", DoctorName.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                    cmd.Parameters.AddWithValue("@DOB", dobString);
                    cmd.Parameters.AddWithValue("@Specialiest", Specialiest.Text);
                    cmd.Parameters.AddWithValue("@Experience", Experience.Text);
                    cmd.Parameters.AddWithValue("@Contactno", Contactno.Text);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
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
        private void button4_Click(object sender, EventArgs e)
        {
            HomePage hom = new HomePage();
            hom.Show();
            this.Hide();
        }

        private void DisplayRec()
        {
            con.Open();
            string query = "Select * from Docto";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gunaDataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                DoctorId.Text = gunaDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            DoctorName.Text = gunaDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Password.Text = gunaDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Gender.SelectedValue = gunaDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DOB.Text = gunaDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Specialiest.Text = gunaDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Experience.Text = gunaDataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Contactno.Text = gunaDataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Address.Text = gunaDataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DoctorId.Text) || string.IsNullOrWhiteSpace(DoctorName.Text) || string.IsNullOrWhiteSpace(Password.Text) || string.IsNullOrWhiteSpace(DOB.Text) || string.IsNullOrWhiteSpace(Gender.Text) || string.IsNullOrWhiteSpace(Specialiest.Text) || string.IsNullOrWhiteSpace(Experience.Text) || string.IsNullOrWhiteSpace(Contactno.Text) || string.IsNullOrWhiteSpace(Address.Text))
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
                    string query = "Update Docto set DoctorName=@DoctorName, Password=@Password, Gender=@Gender, DOB=@DOB, Specialiest=@Specialiest,Experience=@Experience, Contactno=@Contactno, Address=@Address where DoctorId=@DoctorId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DoctorId", DoctorId.Text);
                    cmd.Parameters.AddWithValue("@DoctorName", DoctorName.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender.Text);
                    cmd.Parameters.AddWithValue("@DOB", dobString);
                    cmd.Parameters.AddWithValue("@Specialiest", Specialiest.Text);
                    cmd.Parameters.AddWithValue("@Experience", Experience.Text);
                    cmd.Parameters.AddWithValue("@Contactno", Contactno.Text);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
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
            if (string.IsNullOrWhiteSpace(DoctorId.Text))
            {
                MessageBox.Show("Fill the Information........");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Docto WHERE DoctorId = @DoctorId"; // Corrected parameter name
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DoctorId", DoctorId.Text); // Use the correct parameter name here
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete Doctor Record....");
                    DisplayRec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
