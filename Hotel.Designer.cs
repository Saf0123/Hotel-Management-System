namespace Hotel_Management_System
{
    partial class Hotel
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
            namelbl = new Label();
            locationlbl = new Label();
            contactlbl = new Label();
            txtname = new TextBox();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            txtlocation = new TextBox();
            txtcontact = new TextBox();
            dataGridView1 = new DataGridView();
            hotelidlbl = new Label();
            txthotelid = new TextBox();
            AddBtn = new FontAwesome.Sharp.IconButton();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            DeleteBtn = new FontAwesome.Sharp.IconButton();
            cbstarrating = new ComboBox();
            starratinglbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 10.2F);
            namelbl.ForeColor = Color.Gainsboro;
            namelbl.Location = new Point(51, 11);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(65, 23);
            namelbl.TabIndex = 0;
            namelbl.Text = "Name :";
            // 
            // locationlbl
            // 
            locationlbl.AutoSize = true;
            locationlbl.Font = new Font("Segoe UI", 10.2F);
            locationlbl.ForeColor = Color.Gainsboro;
            locationlbl.Location = new Point(32, 48);
            locationlbl.Name = "locationlbl";
            locationlbl.Size = new Size(84, 23);
            locationlbl.TabIndex = 1;
            locationlbl.Text = "Location :";
            // 
            // contactlbl
            // 
            contactlbl.AutoSize = true;
            contactlbl.Font = new Font("Segoe UI", 10.2F);
            contactlbl.ForeColor = Color.Gainsboro;
            contactlbl.Location = new Point(37, 106);
            contactlbl.Name = "contactlbl";
            contactlbl.Size = new Size(79, 23);
            contactlbl.TabIndex = 2;
            contactlbl.Text = "Contact :";
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(34, 33, 74);
            txtname.Font = new Font("Microsoft Sans Serif", 9F);
            txtname.ForeColor = Color.Gainsboro;
            txtname.Location = new Point(141, 11);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(582, 31);
            txtname.TabIndex = 3;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(32, 19);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(32, 19);
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(32, 19);
            // 
            // txtlocation
            // 
            txtlocation.BackColor = Color.FromArgb(34, 33, 74);
            txtlocation.Font = new Font("Microsoft Sans Serif", 9F);
            txtlocation.ForeColor = Color.Gainsboro;
            txtlocation.Location = new Point(141, 48);
            txtlocation.Multiline = true;
            txtlocation.Name = "txtlocation";
            txtlocation.ScrollBars = ScrollBars.Vertical;
            txtlocation.Size = new Size(582, 52);
            txtlocation.TabIndex = 4;
            // 
            // txtcontact
            // 
            txtcontact.BackColor = Color.FromArgb(34, 33, 74);
            txtcontact.Font = new Font("Microsoft Sans Serif", 9F);
            txtcontact.ForeColor = Color.Gainsboro;
            txtcontact.Location = new Point(141, 106);
            txtcontact.MaxLength = 11;
            txtcontact.Multiline = true;
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(125, 31);
            txtcontact.TabIndex = 5;
            txtcontact.Text = "***********";
            txtcontact.Enter += txtContact_Enter;
            txtcontact.Leave += txtContact_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 260);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 292);
            dataGridView1.TabIndex = 6;
            // 
            // hotelidlbl
            // 
            hotelidlbl.AutoSize = true;
            hotelidlbl.Font = new Font("Segoe UI", 10.2F);
            hotelidlbl.ForeColor = Color.Gainsboro;
            hotelidlbl.Location = new Point(34, 184);
            hotelidlbl.Name = "hotelidlbl";
            hotelidlbl.Size = new Size(82, 23);
            hotelidlbl.TabIndex = 11;
            hotelidlbl.Text = "Hotel ID :";
            // 
            // txthotelid
            // 
            txthotelid.BackColor = Color.FromArgb(34, 33, 74);
            txthotelid.Font = new Font("Microsoft Sans Serif", 9F);
            txthotelid.ForeColor = Color.Gainsboro;
            txthotelid.Location = new Point(141, 180);
            txthotelid.Multiline = true;
            txthotelid.Name = "txthotelid";
            txthotelid.Size = new Size(125, 31);
            txthotelid.TabIndex = 12;
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
            AddBtn.Location = new Point(449, 225);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 29);
            AddBtn.TabIndex = 13;
            AddBtn.Text = "ADD";
            AddBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
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
            UpdateBtn.Location = new Point(667, 225);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 14;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
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
            SearchBtn.Location = new Point(272, 182);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 15;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
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
            DeleteBtn.Location = new Point(558, 225);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(103, 29);
            DeleteBtn.TabIndex = 16;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // cbstarrating
            // 
            cbstarrating.BackColor = Color.FromArgb(26, 25, 62);
            cbstarrating.Cursor = Cursors.Hand;
            cbstarrating.FlatStyle = FlatStyle.Popup;
            cbstarrating.ForeColor = Color.Gainsboro;
            cbstarrating.FormattingEnabled = true;
            cbstarrating.ItemHeight = 20;
            cbstarrating.Location = new Point(141, 144);
            cbstarrating.Name = "cbstarrating";
            cbstarrating.Size = new Size(582, 28);
            cbstarrating.TabIndex = 18;
            cbstarrating.Text = "Select an option...";
            // 
            // starratinglbl
            // 
            starratinglbl.AutoSize = true;
            starratinglbl.Font = new Font("Segoe UI", 10.2F);
            starratinglbl.ForeColor = Color.Gainsboro;
            starratinglbl.Location = new Point(14, 144);
            starratinglbl.Name = "starratinglbl";
            starratinglbl.Size = new Size(102, 23);
            starratinglbl.TabIndex = 17;
            starratinglbl.Text = "Star Rating :";
            // 
            // Hotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(cbstarrating);
            Controls.Add(starratinglbl);
            Controls.Add(DeleteBtn);
            Controls.Add(SearchBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(txthotelid);
            Controls.Add(hotelidlbl);
            Controls.Add(dataGridView1);
            Controls.Add(txtcontact);
            Controls.Add(txtlocation);
            Controls.Add(txtname);
            Controls.Add(contactlbl);
            Controls.Add(locationlbl);
            Controls.Add(namelbl);
            Name = "Hotel";
            Text = "Hotel Management";
            Load += Hotel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namelbl;
        private Label locationlbl;
        private Label contactlbl;
        private TextBox txtname;
        private TextBox txtlocation;
        private TextBox txtcontact;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label hotelidlbl;
        private TextBox txthotelid;
        private FontAwesome.Sharp.IconButton AddBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private ComboBox cbstarrating;
        private Label starratinglbl;
    }
}