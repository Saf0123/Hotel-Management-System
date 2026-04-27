namespace Hotel_Management_System
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button2 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(31, 30, 68);
            label1.Location = new Point(66, 147);
            label1.Name = "label1";
            label1.Size = new Size(141, 45);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Location = new Point(29, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 68);
            panel2.Location = new Point(29, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(31, 30, 68);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(29, 369);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(236, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(31, 30, 68);
            label2.Location = new Point(154, 326);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 7;
            label2.Text = "Clear Fields";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(31, 30, 68);
            label3.Location = new Point(125, 454);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 8;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(66, 208);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 24);
            txtUsername.TabIndex = 9;
            txtUsername.Text = "Username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(66, 275);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(199, 24);
            txtPassword.TabIndex = 10;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(31, 30, 68);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(29, 413);
            button2.Name = "button2";
            button2.Size = new Size(236, 38);
            button2.TabIndex = 11;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(31, 30, 68);
            label5.Location = new Point(114, 346);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 13;
            label5.Text = "Forgot Password";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(290, 496);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button2;
        private Label label5;
    }
}