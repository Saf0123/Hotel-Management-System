namespace Hotel_Management_System
{
    partial class Services
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
            cbservicetype = new ComboBox();
            servicetypelbl = new Label();
            txtservicecharge = new TextBox();
            servicechargelbl = new Label();
            txtbookingid = new TextBox();
            bookingidlbl = new Label();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            txtserviceid = new TextBox();
            serviceidlbl = new Label();
            DeleteBtn = new FontAwesome.Sharp.IconButton();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            AddBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbservicetype
            // 
            cbservicetype.BackColor = Color.FromArgb(26, 25, 62);
            cbservicetype.Cursor = Cursors.Hand;
            cbservicetype.FlatStyle = FlatStyle.Popup;
            cbservicetype.ForeColor = Color.Gainsboro;
            cbservicetype.FormattingEnabled = true;
            cbservicetype.ItemHeight = 20;
            cbservicetype.Location = new Point(191, 59);
            cbservicetype.Name = "cbservicetype";
            cbservicetype.Size = new Size(582, 28);
            cbservicetype.TabIndex = 16;
            cbservicetype.Text = "Select an option...";
            // 
            // servicetypelbl
            // 
            servicetypelbl.AutoSize = true;
            servicetypelbl.Font = new Font("Segoe UI", 10.2F);
            servicetypelbl.ForeColor = Color.Gainsboro;
            servicetypelbl.Location = new Point(54, 59);
            servicetypelbl.Name = "servicetypelbl";
            servicetypelbl.Size = new Size(112, 23);
            servicetypelbl.TabIndex = 15;
            servicetypelbl.Text = "Service Type :";
            // 
            // txtservicecharge
            // 
            txtservicecharge.BackColor = Color.FromArgb(34, 33, 74);
            txtservicecharge.Font = new Font("Microsoft Sans Serif", 9F);
            txtservicecharge.ForeColor = Color.Gainsboro;
            txtservicecharge.Location = new Point(191, 105);
            txtservicecharge.Multiline = true;
            txtservicecharge.Name = "txtservicecharge";
            txtservicecharge.Size = new Size(582, 31);
            txtservicecharge.TabIndex = 14;
            // 
            // servicechargelbl
            // 
            servicechargelbl.AutoSize = true;
            servicechargelbl.Font = new Font("Segoe UI", 10.2F);
            servicechargelbl.ForeColor = Color.Gainsboro;
            servicechargelbl.Location = new Point(34, 105);
            servicechargelbl.Name = "servicechargelbl";
            servicechargelbl.Size = new Size(132, 23);
            servicechargelbl.TabIndex = 13;
            servicechargelbl.Text = "Service Charge :";
            // 
            // txtbookingid
            // 
            txtbookingid.BackColor = Color.FromArgb(34, 33, 74);
            txtbookingid.Font = new Font("Microsoft Sans Serif", 9F);
            txtbookingid.ForeColor = Color.Gainsboro;
            txtbookingid.Location = new Point(191, 12);
            txtbookingid.Multiline = true;
            txtbookingid.Name = "txtbookingid";
            txtbookingid.Size = new Size(582, 31);
            txtbookingid.TabIndex = 12;
            // 
            // bookingidlbl
            // 
            bookingidlbl.AutoSize = true;
            bookingidlbl.Font = new Font("Segoe UI", 10.2F);
            bookingidlbl.ForeColor = Color.Gainsboro;
            bookingidlbl.Location = new Point(63, 12);
            bookingidlbl.Name = "bookingidlbl";
            bookingidlbl.Size = new Size(103, 23);
            bookingidlbl.TabIndex = 11;
            bookingidlbl.Text = "Booking ID :";
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
            SearchBtn.Location = new Point(322, 157);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 19;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtserviceid
            // 
            txtserviceid.BackColor = Color.FromArgb(34, 33, 74);
            txtserviceid.Font = new Font("Microsoft Sans Serif", 9F);
            txtserviceid.ForeColor = Color.Gainsboro;
            txtserviceid.Location = new Point(191, 155);
            txtserviceid.Multiline = true;
            txtserviceid.Name = "txtserviceid";
            txtserviceid.Size = new Size(125, 31);
            txtserviceid.TabIndex = 18;
            // 
            // serviceidlbl
            // 
            serviceidlbl.AutoSize = true;
            serviceidlbl.Font = new Font("Segoe UI", 10.2F);
            serviceidlbl.ForeColor = Color.Gainsboro;
            serviceidlbl.Location = new Point(72, 155);
            serviceidlbl.Name = "serviceidlbl";
            serviceidlbl.Size = new Size(94, 23);
            serviceidlbl.TabIndex = 17;
            serviceidlbl.Text = "Service ID :";
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
            DeleteBtn.Location = new Point(561, 197);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(103, 29);
            DeleteBtn.TabIndex = 23;
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
            UpdateBtn.Location = new Point(670, 197);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 22;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
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
            AddBtn.Location = new Point(452, 197);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 29);
            AddBtn.TabIndex = 21;
            AddBtn.Text = "ADD";
            AddBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 329);
            dataGridView1.TabIndex = 20;
            // 
            // Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(txtserviceid);
            Controls.Add(serviceidlbl);
            Controls.Add(cbservicetype);
            Controls.Add(servicetypelbl);
            Controls.Add(txtservicecharge);
            Controls.Add(servicechargelbl);
            Controls.Add(txtbookingid);
            Controls.Add(bookingidlbl);
            Name = "Services";
            Text = "Services Management";
            Load += Services_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbservicetype;
        private Label servicetypelbl;
        private TextBox txtservicecharge;
        private Label servicechargelbl;
        private TextBox txtbookingid;
        private Label bookingidlbl;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private TextBox txtserviceid;
        private Label serviceidlbl;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton AddBtn;
        private DataGridView dataGridView1;
    }
}