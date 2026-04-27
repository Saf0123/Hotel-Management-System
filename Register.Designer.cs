namespace Hotel_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            BtnRegister = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(353, 125);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(199, 24);
            txtPassword.TabIndex = 21;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(353, 58);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 24);
            txtUsername.TabIndex = 20;
            txtUsername.Text = "Username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(31, 30, 68);
            label3.Location = new Point(410, 244);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 19;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(31, 30, 68);
            label2.Location = new Point(441, 171);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 18;
            label2.Text = "Clear Fields";
            label2.Click += label2_Click;
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = Color.FromArgb(31, 30, 68);
            BtnRegister.FlatStyle = FlatStyle.Flat;
            BtnRegister.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegister.ForeColor = Color.White;
            BtnRegister.Location = new Point(316, 194);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(236, 38);
            BtnRegister.TabIndex = 17;
            BtnRegister.Text = "REGISTER";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += btnRegister_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 30, 68);
            panel2.Location = new Point(316, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(322, 124);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 30, 68);
            panel1.Location = new Point(316, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(322, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(31, 30, 68);
            label1.Location = new Point(43, 169);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 12;
            label1.Text = "REGISTER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(612, 313);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnRegister);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Button BtnRegister;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}