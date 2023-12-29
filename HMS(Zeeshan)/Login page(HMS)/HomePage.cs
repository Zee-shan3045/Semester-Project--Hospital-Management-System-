using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_page_HMS_
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Hide();
            panel3.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Doctor doc = new Doctor();
            doc.Show();
            this.Hide();
            panel4.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Labotory lab = new Labotory();
            lab.Show();
            this.Hide();
            panel5.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Receptionist recp = new Receptionist();
            recp.Show();
            this.Hide();
            panel2.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(100, 85, 100, 85);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
