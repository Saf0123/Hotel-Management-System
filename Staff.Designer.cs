namespace Hotel_Management_System
{
    partial class Staff
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
            txtsalary = new TextBox();
            salarylbl = new Label();
            txtname = new TextBox();
            namelbl = new Label();
            txthotelid = new TextBox();
            hotelidlbl = new Label();
            cbrole = new ComboBox();
            rolelbl = new Label();
            DeleteBtn = new FontAwesome.Sharp.IconButton();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            AddBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            txtstaffid = new TextBox();
            staffidlbl = new Label();
            txtpassword = new TextBox();
            passwordlbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtsalary
            // 
            txtsalary.BackColor = Color.FromArgb(34, 33, 74);
            txtsalary.Font = new Font("Microsoft Sans Serif", 9F);
            txtsalary.ForeColor = Color.Gainsboro;
            txtsalary.Location = new Point(155, 121);
            txtsalary.Multiline = true;
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(582, 31);
            txtsalary.TabIndex = 5;
            // 
            // salarylbl
            // 
            salarylbl.AutoSize = true;
            salarylbl.Font = new Font("Segoe UI", 10.2F);
            salarylbl.ForeColor = Color.Gainsboro;
            salarylbl.Location = new Point(65, 121);
            salarylbl.Name = "salarylbl";
            salarylbl.Size = new Size(64, 23);
            salarylbl.TabIndex = 4;
            salarylbl.Text = "Salary :";
            // 
            // txtname
            // 
            txtname.BackColor = Color.FromArgb(34, 33, 74);
            txtname.Font = new Font("Microsoft Sans Serif", 9F);
            txtname.ForeColor = Color.Gainsboro;
            txtname.Location = new Point(155, 50);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(582, 31);
            txtname.TabIndex = 7;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 10.2F);
            namelbl.ForeColor = Color.Gainsboro;
            namelbl.Location = new Point(64, 50);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(65, 23);
            namelbl.TabIndex = 6;
            namelbl.Text = "Name :";
            // 
            // txthotelid
            // 
            txthotelid.BackColor = Color.FromArgb(34, 33, 74);
            txthotelid.Font = new Font("Microsoft Sans Serif", 9F);
            txthotelid.ForeColor = Color.Gainsboro;
            txthotelid.Location = new Point(155, 12);
            txthotelid.Multiline = true;
            txthotelid.Name = "txthotelid";
            txthotelid.Size = new Size(582, 31);
            txthotelid.TabIndex = 9;
            // 
            // hotelidlbl
            // 
            hotelidlbl.AutoSize = true;
            hotelidlbl.Font = new Font("Segoe UI", 10.2F);
            hotelidlbl.ForeColor = Color.Gainsboro;
            hotelidlbl.Location = new Point(47, 12);
            hotelidlbl.Name = "hotelidlbl";
            hotelidlbl.Size = new Size(82, 23);
            hotelidlbl.TabIndex = 8;
            hotelidlbl.Text = "Hotel ID :";
            // 
            // cbrole
            // 
            cbrole.BackColor = Color.FromArgb(26, 25, 62);
            cbrole.Cursor = Cursors.Hand;
            cbrole.FlatStyle = FlatStyle.Popup;
            cbrole.ForeColor = Color.Gainsboro;
            cbrole.FormattingEnabled = true;
            cbrole.ItemHeight = 20;
            cbrole.Location = new Point(155, 87);
            cbrole.Name = "cbrole";
            cbrole.Size = new Size(582, 28);
            cbrole.TabIndex = 11;
            cbrole.Text = "Select an option...";
            // 
            // rolelbl
            // 
            rolelbl.AutoSize = true;
            rolelbl.Font = new Font("Segoe UI", 10.2F);
            rolelbl.ForeColor = Color.Gainsboro;
            rolelbl.Location = new Point(77, 87);
            rolelbl.Name = "rolelbl";
            rolelbl.Size = new Size(52, 23);
            rolelbl.TabIndex = 10;
            rolelbl.Text = "Role :";
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
            DeleteBtn.Location = new Point(557, 234);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(103, 29);
            DeleteBtn.TabIndex = 20;
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
            UpdateBtn.Location = new Point(666, 234);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 19;
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
            AddBtn.Location = new Point(448, 234);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 29);
            AddBtn.TabIndex = 18;
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
            dataGridView1.Location = new Point(36, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 292);
            dataGridView1.TabIndex = 17;
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
            SearchBtn.Location = new Point(286, 197);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 23;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtstaffid
            // 
            txtstaffid.BackColor = Color.FromArgb(34, 33, 74);
            txtstaffid.Font = new Font("Microsoft Sans Serif", 9F);
            txtstaffid.ForeColor = Color.Gainsboro;
            txtstaffid.Location = new Point(155, 197);
            txtstaffid.Multiline = true;
            txtstaffid.Name = "txtstaffid";
            txtstaffid.Size = new Size(125, 31);
            txtstaffid.TabIndex = 22;
            // 
            // staffidlbl
            // 
            staffidlbl.AutoSize = true;
            staffidlbl.Font = new Font("Segoe UI", 10.2F);
            staffidlbl.ForeColor = Color.Gainsboro;
            staffidlbl.Location = new Point(55, 197);
            staffidlbl.Name = "staffidlbl";
            staffidlbl.Size = new Size(74, 23);
            staffidlbl.TabIndex = 21;
            staffidlbl.Text = "Staff ID :";
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(34, 33, 74);
            txtpassword.Font = new Font("Microsoft Sans Serif", 9F);
            txtpassword.ForeColor = Color.Gainsboro;
            txtpassword.Location = new Point(155, 160);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(582, 31);
            txtpassword.TabIndex = 25;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Segoe UI", 10.2F);
            passwordlbl.ForeColor = Color.Gainsboro;
            passwordlbl.Location = new Point(65, 160);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(89, 23);
            passwordlbl.TabIndex = 24;
            passwordlbl.Text = "Password :";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(txtpassword);
            Controls.Add(passwordlbl);
            Controls.Add(SearchBtn);
            Controls.Add(txtstaffid);
            Controls.Add(staffidlbl);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(cbrole);
            Controls.Add(rolelbl);
            Controls.Add(txthotelid);
            Controls.Add(hotelidlbl);
            Controls.Add(txtname);
            Controls.Add(namelbl);
            Controls.Add(txtsalary);
            Controls.Add(salarylbl);
            Name = "Staff";
            Text = "Staff Management";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsalary;
        private Label salarylbl;
        private TextBox txtname;
        private Label namelbl;
        private TextBox txthotelid;
        private Label hotelidlbl;
        private ComboBox cbrole;
        private Label rolelbl;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton AddBtn;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private TextBox txtstaffid;
        private Label staffidlbl;
        private TextBox txtpassword;
        private Label passwordlbl;
    }
}