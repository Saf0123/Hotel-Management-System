namespace Hotel_Management_System
{
    partial class GuestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestMenu));
            panelMenu = new Panel();
            DeleteAccount = new FontAwesome.Sharp.IconButton();
            PaymentManagement = new FontAwesome.Sharp.IconButton();
            BookingManagement = new FontAwesome.Sharp.IconButton();
            RoomManagement = new FontAwesome.Sharp.IconButton();
            Profile = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            lblTitleChildForm = new Label();
            IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(DeleteAccount);
            panelMenu.Controls.Add(PaymentManagement);
            panelMenu.Controls.Add(BookingManagement);
            panelMenu.Controls.Add(RoomManagement);
            panelMenu.Controls.Add(Profile);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 665);
            panelMenu.TabIndex = 1;
            // 
            // DeleteAccount
            // 
            DeleteAccount.Dock = DockStyle.Bottom;
            DeleteAccount.FlatAppearance.BorderSize = 0;
            DeleteAccount.FlatStyle = FlatStyle.Flat;
            DeleteAccount.ForeColor = Color.Gainsboro;
            DeleteAccount.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DeleteAccount.IconColor = Color.Gainsboro;
            DeleteAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteAccount.IconSize = 32;
            DeleteAccount.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteAccount.Location = new Point(0, 605);
            DeleteAccount.Name = "DeleteAccount";
            DeleteAccount.Padding = new Padding(10, 0, 20, 0);
            DeleteAccount.Size = new Size(220, 60);
            DeleteAccount.TabIndex = 7;
            DeleteAccount.Text = "Delete Account";
            DeleteAccount.TextAlign = ContentAlignment.MiddleLeft;
            DeleteAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteAccount.UseVisualStyleBackColor = true;
            DeleteAccount.Click += DeleteAccount_Click;
            // 
            // PaymentManagement
            // 
            PaymentManagement.Dock = DockStyle.Top;
            PaymentManagement.FlatAppearance.BorderSize = 0;
            PaymentManagement.FlatStyle = FlatStyle.Flat;
            PaymentManagement.ForeColor = Color.Gainsboro;
            PaymentManagement.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            PaymentManagement.IconColor = Color.Gainsboro;
            PaymentManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PaymentManagement.IconSize = 32;
            PaymentManagement.ImageAlign = ContentAlignment.MiddleLeft;
            PaymentManagement.Location = new Point(0, 320);
            PaymentManagement.Name = "PaymentManagement";
            PaymentManagement.Padding = new Padding(10, 0, 20, 0);
            PaymentManagement.Size = new Size(220, 60);
            PaymentManagement.TabIndex = 6;
            PaymentManagement.Text = "Payment";
            PaymentManagement.TextAlign = ContentAlignment.MiddleLeft;
            PaymentManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            PaymentManagement.UseVisualStyleBackColor = true;
            PaymentManagement.Click += PaymentBtn_Click;
            // 
            // BookingManagement
            // 
            BookingManagement.Dock = DockStyle.Top;
            BookingManagement.FlatAppearance.BorderSize = 0;
            BookingManagement.FlatStyle = FlatStyle.Flat;
            BookingManagement.ForeColor = Color.Gainsboro;
            BookingManagement.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            BookingManagement.IconColor = Color.Gainsboro;
            BookingManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BookingManagement.IconSize = 32;
            BookingManagement.ImageAlign = ContentAlignment.MiddleLeft;
            BookingManagement.Location = new Point(0, 260);
            BookingManagement.Name = "BookingManagement";
            BookingManagement.Padding = new Padding(10, 0, 20, 0);
            BookingManagement.Size = new Size(220, 60);
            BookingManagement.TabIndex = 5;
            BookingManagement.Text = "Booking";
            BookingManagement.TextAlign = ContentAlignment.MiddleLeft;
            BookingManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            BookingManagement.UseVisualStyleBackColor = true;
            BookingManagement.Click += BookingBtn_Click;
            // 
            // RoomManagement
            // 
            RoomManagement.Dock = DockStyle.Top;
            RoomManagement.FlatAppearance.BorderSize = 0;
            RoomManagement.FlatStyle = FlatStyle.Flat;
            RoomManagement.ForeColor = Color.Gainsboro;
            RoomManagement.IconChar = FontAwesome.Sharp.IconChar.Bed;
            RoomManagement.IconColor = Color.Gainsboro;
            RoomManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RoomManagement.IconSize = 32;
            RoomManagement.ImageAlign = ContentAlignment.MiddleLeft;
            RoomManagement.Location = new Point(0, 200);
            RoomManagement.Name = "RoomManagement";
            RoomManagement.Padding = new Padding(10, 0, 20, 0);
            RoomManagement.Size = new Size(220, 60);
            RoomManagement.TabIndex = 3;
            RoomManagement.Text = "Room";
            RoomManagement.TextAlign = ContentAlignment.MiddleLeft;
            RoomManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            RoomManagement.UseVisualStyleBackColor = true;
            RoomManagement.Click += RoomBtn_Click;
            // 
            // Profile
            // 
            Profile.Dock = DockStyle.Top;
            Profile.FlatAppearance.BorderSize = 0;
            Profile.FlatStyle = FlatStyle.Flat;
            Profile.ForeColor = Color.Gainsboro;
            Profile.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            Profile.IconColor = Color.Gainsboro;
            Profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Profile.IconSize = 32;
            Profile.ImageAlign = ContentAlignment.MiddleLeft;
            Profile.Location = new Point(0, 140);
            Profile.Name = "Profile";
            Profile.Padding = new Padding(10, 0, 20, 0);
            Profile.Size = new Size(220, 60);
            Profile.TabIndex = 1;
            Profile.Text = "Profile";
            Profile.TextAlign = ContentAlignment.MiddleLeft;
            Profile.TextImageRelation = TextImageRelation.ImageBeforeText;
            Profile.UseVisualStyleBackColor = true;
            Profile.Click += ProfileBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 20, 0);
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(21, 34);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(176, 67);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(IconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(821, 75);
            panelTitleBar.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(65, 12);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(74, 28);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home ";
            // 
            // IconCurrentChildForm
            // 
            IconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            IconCurrentChildForm.ForeColor = Color.FromArgb(128, 128, 255);
            IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            IconCurrentChildForm.IconColor = Color.FromArgb(128, 128, 255);
            IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconCurrentChildForm.IconSize = 39;
            IconCurrentChildForm.Location = new Point(19, 12);
            IconCurrentChildForm.Name = "IconCurrentChildForm";
            IconCurrentChildForm.Size = new Size(40, 39);
            IconCurrentChildForm.TabIndex = 0;
            IconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 75);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(821, 590);
            panelDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // GuestMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 665);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "GuestMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuestMenu";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton PaymentManagement;
        private FontAwesome.Sharp.IconButton BookingManagement;
        private FontAwesome.Sharp.IconButton RoomManagement;
        private FontAwesome.Sharp.IconButton Profile;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton DeleteAccount;
    }
}