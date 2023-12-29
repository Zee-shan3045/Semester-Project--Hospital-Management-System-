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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login_page_HMS_
{
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HMS(Login);Integrated Security=True");
        private static string Sellernamee = "";
        public string Seller_Name { get; private set; }
        public static string Seller_namee { get; internal set; }
        public Signup()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
                if (Firstname.Text == " " || Username.Text == " " || Email.Text == " " || Password.Text == " ")
                {
                    MessageBox.Show("Please Enter all Fields.....");
                }
                else
                {
                try
                {
                    con.Open();

                    string checkusername = "SELECT * FROM Signup WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(checkusername, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        if (dt.Rows.Count >= 1)
                        {
                            MessageBox.Show(Username.Text + "Try Again! Enter Info....", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertdata = "INSERT INTO Signup (Firstname, Username, Email, Password) VALUES (@Firstname, @Username, @Email, @Password)";
                            using (SqlCommand cmdd = new SqlCommand(insertdata, con))
                            {
                                cmdd.Parameters.AddWithValue("@Firstname", Firstname.Text);
                                cmdd.Parameters.AddWithValue("@Username", Username.Text);
                                cmdd.Parameters.AddWithValue("@Email", Email.Text);
                                cmdd.Parameters.AddWithValue("@Password", Password.Text);
                                cmdd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Login log = new Login();
                                log.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }  
                   
                }
 
        }
        private void signup_show_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_show.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
