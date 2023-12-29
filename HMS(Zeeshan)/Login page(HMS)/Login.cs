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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CBQO5S5\\SQLEXPRESS;Initial Catalog=HMS(Login);Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_register_Click(object sender, EventArgs e)
        {
            Signup upform = new Signup();
            upform.Show();
            this.Hide();
        }
        private void Logib_btn_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Select Role Enter Username And Password");
            }
            else
            {
                if (SelCb.SelectedItem.ToString() == "Doctor")
                {

                    if (con.State != ConnectionState.Open)
                    {

                        try
                        {
                            con.Open();
                            string query = "Select * From Signup Where Username = @Username And Password = @Password";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Username", Username.Text);
                                cmd.Parameters.AddWithValue("@Password", Password.Text);
                                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                DataTable ta = new DataTable();
                                sda.Fill(ta);
                                if (ta.Rows.Count >= 1)
                                {
                                    HomePage sel = new HomePage();
                                    sel.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Error /Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error to Connection Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
                else if (SelCb.SelectedItem.ToString() == "Receptionists")
                {

                    if (con.State != ConnectionState.Open)
                    {

                        try
                        {
                            con.Open();
                            string query = "Select * From Signup Where Username = @Username And Password = @Password";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Username", Username.Text);
                                cmd.Parameters.AddWithValue("@Password", Password.Text);
                                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                DataTable ta = new DataTable();
                                sda.Fill(ta);
                                if (ta.Rows.Count >= 1)
                                {
                                    HomePage sel = new HomePage();
                                    sel.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Error /Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error to Connection Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
                else if (SelCb.SelectedItem.ToString() == "Patient")
                {
                    if (con.State != ConnectionState.Open)
                    {

                        try
                        {
                            con.Open();
                            string query = "Select * From Signup Where Username = @Username And Password = @Password";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Username", Username.Text);
                                cmd.Parameters.AddWithValue("@Password", Password.Text);
                                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                DataTable ta = new DataTable();
                                sda.Fill(ta);
                                if (ta.Rows.Count >= 1)
                                {
                                    HomePage sel = new HomePage();
                                    sel.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Error /Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error to Connection Database", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }
        private void login_Show_CheckedChanged(object sender, EventArgs e)
        {
            if(login_Show.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }
    }
}
