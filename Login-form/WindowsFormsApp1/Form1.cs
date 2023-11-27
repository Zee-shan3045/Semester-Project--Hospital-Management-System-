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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=dbcs3;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            PopulateRoles();
        }
        private void PopulateRoles()
        {
            // Populate the ComboBox with roles (Doctor, Patient, Receptionist)
            cbRoles.Items.Add("Doctor");
            cbRoles.Items.Add("Patient");
            cbRoles.Items.Add("Receptionist");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private bool IsValidCredentials(string role, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query the database to check if the credentials are valid
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Role = @Role";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string role = cbRoles.SelectedItem as string;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check role and credentials against the database
            if (IsValidCredentials(role, username, password))
            {
                MessageBox.Show($"\t\tLogin successful\t\t.\n\t\tWelcome {role} {username}!\t\t");
                // Open the respective form based on the logged-in roles
                OpenRoleForm(role);
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }


        private void OpenRoleForm(string role)
        {
            // Open the respective form based on the logged-in role
            switch (role)
            {
                case "Patient":
                    new PatientForm().Show();
                    break;
                case "Doctor":
                    new DoctorForm().Show();
                    break;
                case "Receptionist":
                    new ReceptionistForm().Show();
                    break;
            }

            // Close the login form
            this.Hide();
        }



    }
}
