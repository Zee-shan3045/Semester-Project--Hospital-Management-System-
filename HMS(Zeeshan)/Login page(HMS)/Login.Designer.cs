namespace Login_page_HMS_
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelCb = new System.Windows.Forms.ComboBox();
            this.Login_register = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_Show = new System.Windows.Forms.CheckBox();
            this.Logib_btn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SelCb);
            this.panel1.Controls.Add(this.Login_register);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.login_Show);
            this.panel1.Controls.Add(this.Logib_btn);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lable2);
            this.panel1.Controls.Add(this.log);
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(188, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 470);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SelCb
            // 
            this.SelCb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelCb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SelCb.FormattingEnabled = true;
            this.SelCb.Items.AddRange(new object[] {
            "Doctor",
            "Receptionists",
            "Patient"});
            this.SelCb.Location = new System.Drawing.Point(77, 100);
            this.SelCb.Name = "SelCb";
            this.SelCb.Size = new System.Drawing.Size(223, 30);
            this.SelCb.TabIndex = 15;
            this.SelCb.Text = "SELECT ROLE";
            // 
            // Login_register
            // 
            this.Login_register.AutoSize = true;
            this.Login_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_register.ForeColor = System.Drawing.Color.White;
            this.Login_register.Location = new System.Drawing.Point(254, 410);
            this.Login_register.Name = "Login_register";
            this.Login_register.Size = new System.Drawing.Size(114, 19);
            this.Login_register.TabIndex = 8;
            this.Login_register.Text = "Resgister Here";
            this.Login_register.Click += new System.EventHandler(this.Login_register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Don\'t have an Account?";
            // 
            // login_Show
            // 
            this.login_Show.AutoSize = true;
            this.login_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Show.ForeColor = System.Drawing.Color.White;
            this.login_Show.Location = new System.Drawing.Point(233, 283);
            this.login_Show.Name = "login_Show";
            this.login_Show.Size = new System.Drawing.Size(102, 17);
            this.login_Show.TabIndex = 6;
            this.login_Show.Text = "Show Password";
            this.login_Show.UseVisualStyleBackColor = true;
            this.login_Show.CheckedChanged += new System.EventHandler(this.login_Show_CheckedChanged);
            // 
            // Logib_btn
            // 
            this.Logib_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.Logib_btn.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logib_btn.ForeColor = System.Drawing.Color.White;
            this.Logib_btn.Location = new System.Drawing.Point(138, 328);
            this.Logib_btn.Name = "Logib_btn";
            this.Logib_btn.Size = new System.Drawing.Size(132, 41);
            this.Logib_btn.TabIndex = 5;
            this.Logib_btn.Text = "LOGIN";
            this.Logib_btn.UseVisualStyleBackColor = false;
            this.Logib_btn.Click += new System.EventHandler(this.Logib_btn_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(77, 249);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(258, 28);
            this.Password.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(77, 179);
            this.Username.Multiline = true;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(258, 28);
            this.Username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.ForeColor = System.Drawing.Color.White;
            this.lable2.Location = new System.Drawing.Point(72, 151);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(115, 25);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Username";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(96, 10);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(239, 58);
            this.log.TabIndex = 0;
            this.log.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(779, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.CheckBox login_Show;
        private System.Windows.Forms.Button Logib_btn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label Login_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelCb;
    }
}