namespace Hotel_Management_System
{
    partial class GProfile
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
            txtcontact = new TextBox();
            contactlbl = new Label();
            txtaddress = new TextBox();
            addresslbl = new Label();
            txtemail = new TextBox();
            emaillbl = new Label();
            txtname = new TextBox();
            namelbl = new Label();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            AddBtn = new FontAwesome.Sharp.IconButton();
            txtprofileid = new TextBox();
            profileidlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtcontact
            // 
            txtcontact.BackColor = Color.FromArgb(34, 33, 74);
            txtcontact.Font = new Font("Microsoft Sans Serif", 9F);
            txtcontact.ForeColor = Color.Gainsboro;
            txtcontact.Location = new Point(164, 112);
            txtcontact.MaxLength = 11;
            txtcontact.Multiline = true;
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(125, 31);
            txtcontact.TabIndex = 19;
            txtcontact.Text = "***********";
            // 
            // contactlbl
            // 
            contactlbl.AutoSize = true;
            contactlbl.Font = new Font("Segoe UI", 10.2F);
            contactlbl.ForeColor = Color.Gainsboro;
            contactlbl.Location = new Point(55, 112);
            contactlbl.Name = "contactlbl";
            contactlbl.Size = new Size(79, 23);
            contactlbl.TabIndex = 18;
            contactlbl.Text = "Contact :";
            // 
            // txtaddress
            // 
            txtaddress.BackColor = Color.FromArgb(34, 33, 74);
            txtaddress.Font = new Font("Microsoft Sans Serif", 9F);
            txtaddress.ForeColor = Color.Gainsboro;
            txtaddress.Location = new Point(164, 159);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.ScrollBars = ScrollBars.Vertical;
            txtaddress.Size = new Size(582, 52);
            txtaddress.TabIndex = 17;
            // 
            // addresslbl
            // 
            addresslbl.AutoSize = true;
            addresslbl.Font = new Font("Segoe UI", 10.2F);
            addresslbl.ForeColor = Color.Gainsboro;
            addresslbl.Location = new Point(55, 159);
            addresslbl.Name = "addresslbl";
            addresslbl.Size = new Size(79, 23);
            addresslbl.TabIndex = 16;
            addresslbl.Text = "Address :";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.FromArgb(34, 33, 74);
            txtemail.Font = new Font("Microsoft Sans Serif", 9F);
            txtemail.ForeColor = Color.Gainsboro;
            txtemail.Location = new Point(164, 69);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(582, 31);
            txtemail.TabIndex = 15;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Segoe UI", 10.2F);
            emaillbl.ForeColor = Color.Gainsboro;
            emaillbl.Location = new Point(74, 69);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(60, 23);
            emaillbl.TabIndex = 14;
            emaillbl.Text = "Email :";
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(34, 33, 74);
            txtname.Font = new Font("Microsoft Sans Serif", 9F);
            txtname.ForeColor = Color.Gainsboro;
            txtname.Location = new Point(164, 28);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(582, 31);
            txtname.TabIndex = 13;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 10.2F);
            namelbl.ForeColor = Color.Gainsboro;
            namelbl.Location = new Point(69, 28);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(65, 23);
            namelbl.TabIndex = 12;
            namelbl.Text = "Name :";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.SteelBlue;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Black;
            UpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Pen;
            UpdateBtn.IconColor = Color.Black;
            UpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UpdateBtn.IconSize = 20;
            UpdateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateBtn.Location = new Point(295, 229);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 22;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 268);
            dataGridView1.TabIndex = 23;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddBtn.BackColor = Color.SeaGreen;
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Black;
            AddBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            AddBtn.IconColor = Color.Black;
            AddBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBtn.IconSize = 20;
            AddBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddBtn.Location = new Point(667, 247);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 29);
            AddBtn.TabIndex = 24;
            AddBtn.Text = "ADD";
            AddBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // txtprofileid
            // 
            txtprofileid.BackColor = Color.FromArgb(34, 33, 74);
            txtprofileid.Font = new Font("Microsoft Sans Serif", 9F);
            txtprofileid.ForeColor = Color.Gainsboro;
            txtprofileid.Location = new Point(164, 227);
            txtprofileid.Multiline = true;
            txtprofileid.Name = "txtprofileid";
            txtprofileid.Size = new Size(125, 31);
            txtprofileid.TabIndex = 26;
            // 
            // profileidlbl
            // 
            profileidlbl.AutoSize = true;
            profileidlbl.Font = new Font("Segoe UI", 10.2F);
            profileidlbl.ForeColor = Color.Gainsboro;
            profileidlbl.Location = new Point(45, 231);
            profileidlbl.Name = "profileidlbl";
            profileidlbl.Size = new Size(89, 23);
            profileidlbl.TabIndex = 25;
            profileidlbl.Text = "Profile ID :";
            // 
            // GProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(txtprofileid);
            Controls.Add(profileidlbl);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(UpdateBtn);
            Controls.Add(txtcontact);
            Controls.Add(contactlbl);
            Controls.Add(txtaddress);
            Controls.Add(addresslbl);
            Controls.Add(txtemail);
            Controls.Add(emaillbl);
            Controls.Add(txtname);
            Controls.Add(namelbl);
            Name = "GProfile";
            Text = "Profile";
            Load += GProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcontact;
        private Label contactlbl;
        private TextBox txtaddress;
        private Label addresslbl;
        private TextBox txtemail;
        private Label emaillbl;
        private TextBox txtname;
        private Label namelbl;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private FontAwesome.Sharp.IconButton AddBtn;
        private TextBox txtprofileid;
        private Label profileidlbl;
    }
}