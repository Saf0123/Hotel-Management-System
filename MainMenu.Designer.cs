namespace Hotel_Management_System
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelMenu = new Panel();
            servicesManagement = new FontAwesome.Sharp.IconButton();
            StaffManagement = new FontAwesome.Sharp.IconButton();
            PaymentManagement = new FontAwesome.Sharp.IconButton();
            BookingManagement = new FontAwesome.Sharp.IconButton();
            GuestManagement = new FontAwesome.Sharp.IconButton();
            RoomManagement = new FontAwesome.Sharp.IconButton();
            HotelManagement = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            lblTitleChildForm = new Label();
            IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
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
            panelMenu.Controls.Add(servicesManagement);
            panelMenu.Controls.Add(StaffManagement);
            panelMenu.Controls.Add(PaymentManagement);
            panelMenu.Controls.Add(BookingManagement);
            panelMenu.Controls.Add(GuestManagement);
            panelMenu.Controls.Add(RoomManagement);
            panelMenu.Controls.Add(HotelManagement);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 665);
            panelMenu.TabIndex = 0;
            // 
            // servicesManagement
            // 
            servicesManagement.Dock = DockStyle.Top;
            servicesManagement.FlatAppearance.BorderSize = 0;
            servicesManagement.FlatStyle = FlatStyle.Flat;
            servicesManagement.ForeColor = Color.Gainsboro;
            servicesManagement.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            servicesManagement.IconColor = Color.Gainsboro;
            servicesManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            servicesManagement.IconSize = 32;
            servicesManagement.ImageAlign = ContentAlignment.MiddleLeft;
            servicesManagement.Location = new Point(0, 500);
            servicesManagement.Name = "servicesManagement";
            servicesManagement.Padding = new Padding(10, 0, 20, 0);
            servicesManagement.Size = new Size(220, 60);
            servicesManagement.TabIndex = 8;
            servicesManagement.Text = "Services";
            servicesManagement.TextAlign = ContentAlignment.MiddleLeft;
            servicesManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            servicesManagement.UseVisualStyleBackColor = true;
            servicesManagement.Click += ServicesBtn_Click;
            // 
            // StaffManagement
            // 
            StaffManagement.Dock = DockStyle.Top;
            StaffManagement.FlatAppearance.BorderSize = 0;
            StaffManagement.FlatStyle = FlatStyle.Flat;
            StaffManagement.ForeColor = Color.Gainsboro;
            StaffManagement.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            StaffManagement.IconColor = Color.Gainsboro;
            StaffManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StaffManagement.IconSize = 32;
            StaffManagement.ImageAlign = ContentAlignment.MiddleLeft;
            StaffManagement.Location = new Point(0, 440);
            StaffManagement.Name = "StaffManagement";
            StaffManagement.Padding = new Padding(10, 0, 20, 0);
            StaffManagement.Size = new Size(220, 60);
            StaffManagement.TabIndex = 7;
            StaffManagement.Text = "Staff";
            StaffManagement.TextAlign = ContentAlignment.MiddleLeft;
            StaffManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            StaffManagement.UseVisualStyleBackColor = true;
            StaffManagement.Click += StaffBtn_Click;
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
            PaymentManagement.Location = new Point(0, 380);
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
            BookingManagement.Location = new Point(0, 320);
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
            // GuestManagement
            // 
            GuestManagement.Dock = DockStyle.Top;
            GuestManagement.FlatAppearance.BorderSize = 0;
            GuestManagement.FlatStyle = FlatStyle.Flat;
            GuestManagement.ForeColor = Color.Gainsboro;
            GuestManagement.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            GuestManagement.IconColor = Color.Gainsboro;
            GuestManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            GuestManagement.IconSize = 32;
            GuestManagement.ImageAlign = ContentAlignment.MiddleLeft;
            GuestManagement.Location = new Point(0, 260);
            GuestManagement.Name = "GuestManagement";
            GuestManagement.Padding = new Padding(10, 0, 20, 0);
            GuestManagement.Size = new Size(220, 60);
            GuestManagement.TabIndex = 4;
            GuestManagement.Text = "Guest";
            GuestManagement.TextAlign = ContentAlignment.MiddleLeft;
            GuestManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            GuestManagement.UseVisualStyleBackColor = true;
            GuestManagement.Click += GuestBtn_Click;
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
            // HotelManagement
            // 
            HotelManagement.Dock = DockStyle.Top;
            HotelManagement.FlatAppearance.BorderSize = 0;
            HotelManagement.FlatStyle = FlatStyle.Flat;
            HotelManagement.ForeColor = Color.Gainsboro;
            HotelManagement.IconChar = FontAwesome.Sharp.IconChar.Building;
            HotelManagement.IconColor = Color.Gainsboro;
            HotelManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HotelManagement.IconSize = 32;
            HotelManagement.ImageAlign = ContentAlignment.MiddleLeft;
            HotelManagement.Location = new Point(0, 140);
            HotelManagement.Name = "HotelManagement";
            HotelManagement.Padding = new Padding(10, 0, 20, 0);
            HotelManagement.Size = new Size(220, 60);
            HotelManagement.TabIndex = 2;
            HotelManagement.Text = "Hotel";
            HotelManagement.TextAlign = ContentAlignment.MiddleLeft;
            HotelManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            HotelManagement.UseVisualStyleBackColor = true;
            HotelManagement.Click += HotelBtn_Click;
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
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
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
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(821, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(821, 581);
            panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 665);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin ";
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
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton StaffManagement;
        private FontAwesome.Sharp.IconButton PaymentManagement;
        private FontAwesome.Sharp.IconButton BookingManagement;
        private FontAwesome.Sharp.IconButton GuestManagement;
        private FontAwesome.Sharp.IconButton RoomManagement;
        private FontAwesome.Sharp.IconButton HotelManagement;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton servicesManagement;
    }
}
