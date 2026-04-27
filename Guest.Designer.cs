namespace Hotel_Management_System
{
    partial class Guest
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
            txtname = new TextBox();
            namelbl = new Label();
            txtemail = new TextBox();
            emaillbl = new Label();
            txtaddress = new TextBox();
            addresslbl = new Label();
            txtcontact = new TextBox();
            contactlbl = new Label();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            txtguestid = new TextBox();
            guestidlbl = new Label();
            DeleteBtn = new FontAwesome.Sharp.IconButton();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(34, 33, 74);
            txtname.Font = new Font("Microsoft Sans Serif", 9F);
            txtname.ForeColor = Color.Gainsboro;
            txtname.Location = new Point(155, 12);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(582, 31);
            txtname.TabIndex = 5;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 10.2F);
            namelbl.ForeColor = Color.Gainsboro;
            namelbl.Location = new Point(60, 12);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(65, 23);
            namelbl.TabIndex = 4;
            namelbl.Text = "Name :";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.FromArgb(34, 33, 74);
            txtemail.Font = new Font("Microsoft Sans Serif", 9F);
            txtemail.ForeColor = Color.Gainsboro;
            txtemail.Location = new Point(155, 53);
            txtemail.Multiline = true;
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(582, 31);
            txtemail.TabIndex = 7;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Font = new Font("Segoe UI", 10.2F);
            emaillbl.ForeColor = Color.Gainsboro;
            emaillbl.Location = new Point(65, 53);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(60, 23);
            emaillbl.TabIndex = 6;
            emaillbl.Text = "Email :";
            // 
            // txtaddress
            // 
            txtaddress.BackColor = Color.FromArgb(34, 33, 74);
            txtaddress.Font = new Font("Microsoft Sans Serif", 9F);
            txtaddress.ForeColor = Color.Gainsboro;
            txtaddress.Location = new Point(155, 143);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.ScrollBars = ScrollBars.Vertical;
            txtaddress.Size = new Size(582, 52);
            txtaddress.TabIndex = 9;
            // 
            // addresslbl
            // 
            addresslbl.AutoSize = true;
            addresslbl.Font = new Font("Segoe UI", 10.2F);
            addresslbl.ForeColor = Color.Gainsboro;
            addresslbl.Location = new Point(46, 143);
            addresslbl.Name = "addresslbl";
            addresslbl.Size = new Size(79, 23);
            addresslbl.TabIndex = 8;
            addresslbl.Text = "Address :";
            // 
            // txtcontact
            // 
            txtcontact.BackColor = Color.FromArgb(34, 33, 74);
            txtcontact.Font = new Font("Microsoft Sans Serif", 9F);
            txtcontact.ForeColor = Color.Gainsboro;
            txtcontact.Location = new Point(155, 96);
            txtcontact.MaxLength = 11;
            txtcontact.Multiline = true;
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(125, 31);
            txtcontact.TabIndex = 11;
            txtcontact.Text = "***********";
            // 
            // contactlbl
            // 
            contactlbl.AutoSize = true;
            contactlbl.Font = new Font("Segoe UI", 10.2F);
            contactlbl.ForeColor = Color.Gainsboro;
            contactlbl.Location = new Point(46, 96);
            contactlbl.Name = "contactlbl";
            contactlbl.Size = new Size(79, 23);
            contactlbl.TabIndex = 10;
            contactlbl.Text = "Contact :";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.DimGray;
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatAppearance.MouseOverBackColor = Color.Gray;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.Black;
            SearchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            SearchBtn.IconColor = Color.Black;
            SearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchBtn.IconSize = 20;
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(286, 214);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 18;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtguestid
            // 
            txtguestid.BackColor = Color.FromArgb(34, 33, 74);
            txtguestid.Font = new Font("Microsoft Sans Serif", 9F);
            txtguestid.ForeColor = Color.Gainsboro;
            txtguestid.Location = new Point(155, 212);
            txtguestid.Multiline = true;
            txtguestid.Name = "txtguestid";
            txtguestid.Size = new Size(125, 31);
            txtguestid.TabIndex = 17;
            // 
            // guestidlbl
            // 
            guestidlbl.AutoSize = true;
            guestidlbl.Font = new Font("Segoe UI", 10.2F);
            guestidlbl.ForeColor = Color.Gainsboro;
            guestidlbl.Location = new Point(40, 216);
            guestidlbl.Name = "guestidlbl";
            guestidlbl.Size = new Size(85, 23);
            guestidlbl.TabIndex = 16;
            guestidlbl.Text = "Guest ID :";
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteBtn.BackColor = Color.IndianRed;
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DeleteBtn.IconColor = Color.Black;
            DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBtn.IconSize = 20;
            DeleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteBtn.Location = new Point(564, 258);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(103, 29);
            DeleteBtn.TabIndex = 22;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            UpdateBtn.Location = new Point(673, 258);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 21;
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
            dataGridView1.Location = new Point(43, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 268);
            dataGridView1.TabIndex = 19;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(txtguestid);
            Controls.Add(guestidlbl);
            Controls.Add(txtcontact);
            Controls.Add(contactlbl);
            Controls.Add(txtaddress);
            Controls.Add(addresslbl);
            Controls.Add(txtemail);
            Controls.Add(emaillbl);
            Controls.Add(txtname);
            Controls.Add(namelbl);
            Name = "Guest";
            Text = "Guest Management";
            Load += Guest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private Label namelbl;
        private TextBox txtemail;
        private Label emaillbl;
        private TextBox txtaddress;
        private Label addresslbl;
        private TextBox txtcontact;
        private Label contactlbl;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private TextBox txtguestid;
        private Label guestidlbl;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private DataGridView dataGridView1;
    }
}