namespace Hotel_Management_System
{
    partial class Room
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
            txthotelid = new TextBox();
            hotelidlbl = new Label();
            txtppn = new TextBox();
            roomtypelbl = new Label();
            cbroomtype = new ComboBox();
            ppnlbl = new Label();
            rbyes = new RadioButton();
            rbno = new RadioButton();
            availabilitylbl = new Label();
            roomidlbl = new Label();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            txtroomid = new TextBox();
            DeleteBtn = new FontAwesome.Sharp.IconButton();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            AddBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txthotelid
            // 
            txthotelid.BackColor = Color.FromArgb(34, 33, 74);
            txthotelid.Font = new Font("Microsoft Sans Serif", 9F);
            txthotelid.ForeColor = Color.Gainsboro;
            txthotelid.Location = new Point(169, 13);
            txthotelid.Multiline = true;
            txthotelid.Name = "txthotelid";
            txthotelid.Size = new Size(582, 31);
            txthotelid.TabIndex = 5;
            // 
            // hotelidlbl
            // 
            hotelidlbl.AutoSize = true;
            hotelidlbl.Font = new Font("Segoe UI", 10.2F);
            hotelidlbl.ForeColor = Color.Gainsboro;
            hotelidlbl.Location = new Point(79, 13);
            hotelidlbl.Name = "hotelidlbl";
            hotelidlbl.Size = new Size(77, 23);
            hotelidlbl.TabIndex = 4;
            hotelidlbl.Text = "Hotel ID:";
            // 
            // txtppn
            // 
            txtppn.BackColor = Color.FromArgb(34, 33, 74);
            txtppn.Font = new Font("Microsoft Sans Serif", 9F);
            txtppn.ForeColor = Color.Gainsboro;
            txtppn.Location = new Point(169, 98);
            txtppn.Multiline = true;
            txtppn.Name = "txtppn";
            txtppn.Size = new Size(582, 31);
            txtppn.TabIndex = 7;
            // 
            // roomtypelbl
            // 
            roomtypelbl.AutoSize = true;
            roomtypelbl.Font = new Font("Segoe UI", 10.2F);
            roomtypelbl.ForeColor = Color.Gainsboro;
            roomtypelbl.Location = new Point(52, 54);
            roomtypelbl.Name = "roomtypelbl";
            roomtypelbl.Size = new Size(104, 23);
            roomtypelbl.TabIndex = 6;
            roomtypelbl.Text = "Room Type :";
            // 
            // cbroomtype
            // 
            cbroomtype.BackColor = Color.FromArgb(26, 25, 62);
            cbroomtype.Cursor = Cursors.Hand;
            cbroomtype.FlatStyle = FlatStyle.Popup;
            cbroomtype.ForeColor = Color.Gainsboro;
            cbroomtype.FormattingEnabled = true;
            cbroomtype.ItemHeight = 20;
            cbroomtype.Location = new Point(169, 54);
            cbroomtype.Name = "cbroomtype";
            cbroomtype.Size = new Size(582, 28);
            cbroomtype.TabIndex = 8;
            cbroomtype.Text = "Select an option...";
            cbroomtype.Enter += comboBox1_Enter;
            cbroomtype.Leave += comboBox1_Leave;
            // 
            // ppnlbl
            // 
            ppnlbl.AutoSize = true;
            ppnlbl.Font = new Font("Segoe UI", 10.2F);
            ppnlbl.ForeColor = Color.Gainsboro;
            ppnlbl.Location = new Point(23, 98);
            ppnlbl.Name = "ppnlbl";
            ppnlbl.Size = new Size(133, 23);
            ppnlbl.TabIndex = 9;
            ppnlbl.Text = "Price Per Night :";
            // 
            // rbyes
            // 
            rbyes.AutoSize = true;
            rbyes.Checked = true;
            rbyes.Cursor = Cursors.Hand;
            rbyes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbyes.ForeColor = Color.Gainsboro;
            rbyes.Location = new Point(169, 150);
            rbyes.Name = "rbyes";
            rbyes.Size = new Size(55, 24);
            rbyes.TabIndex = 10;
            rbyes.TabStop = true;
            rbyes.Text = "YES";
            rbyes.UseVisualStyleBackColor = true;
            // 
            // rbno
            // 
            rbno.AutoSize = true;
            rbno.Cursor = Cursors.Hand;
            rbno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbno.ForeColor = Color.Gainsboro;
            rbno.Location = new Point(300, 150);
            rbno.Name = "rbno";
            rbno.Size = new Size(53, 24);
            rbno.TabIndex = 11;
            rbno.Text = "NO";
            rbno.UseVisualStyleBackColor = true;
            // 
            // availabilitylbl
            // 
            availabilitylbl.AutoSize = true;
            availabilitylbl.Font = new Font("Segoe UI", 10.2F);
            availabilitylbl.ForeColor = Color.Gainsboro;
            availabilitylbl.Location = new Point(56, 150);
            availabilitylbl.Name = "availabilitylbl";
            availabilitylbl.Size = new Size(100, 23);
            availabilitylbl.TabIndex = 12;
            availabilitylbl.Text = "Availability :";
            // 
            // roomidlbl
            // 
            roomidlbl.AutoSize = true;
            roomidlbl.Font = new Font("Segoe UI", 10.2F);
            roomidlbl.ForeColor = Color.Gainsboro;
            roomidlbl.Location = new Point(75, 192);
            roomidlbl.Name = "roomidlbl";
            roomidlbl.Size = new Size(81, 23);
            roomidlbl.TabIndex = 13;
            roomidlbl.Text = "Room ID:";
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
            SearchBtn.Location = new Point(300, 194);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 17;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtroomid
            // 
            txtroomid.BackColor = Color.FromArgb(34, 33, 74);
            txtroomid.Font = new Font("Microsoft Sans Serif", 9F);
            txtroomid.ForeColor = Color.Gainsboro;
            txtroomid.Location = new Point(169, 192);
            txtroomid.Multiline = true;
            txtroomid.Name = "txtroomid";
            txtroomid.Size = new Size(125, 31);
            txtroomid.TabIndex = 16;
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
            DeleteBtn.Location = new Point(559, 241);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(103, 29);
            DeleteBtn.TabIndex = 21;
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
            UpdateBtn.Location = new Point(668, 241);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 20;
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
            AddBtn.Location = new Point(450, 241);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 29);
            AddBtn.TabIndex = 19;
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
            dataGridView1.Location = new Point(35, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(736, 277);
            dataGridView1.TabIndex = 18;
            // 
            // Room
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
            Controls.Add(txtroomid);
            Controls.Add(roomidlbl);
            Controls.Add(availabilitylbl);
            Controls.Add(rbno);
            Controls.Add(rbyes);
            Controls.Add(ppnlbl);
            Controls.Add(cbroomtype);
            Controls.Add(txtppn);
            Controls.Add(roomtypelbl);
            Controls.Add(txthotelid);
            Controls.Add(hotelidlbl);
            Name = "Room";
            Text = "Room Management";
            Load += Room_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txthotelid;
        private Label hotelidlbl;
        private TextBox txtppn;
        private Label roomtypelbl;
        private ComboBox cbroomtype;
        private Label ppnlbl;
        private RadioButton rbyes;
        private RadioButton rbno;
        private Label availabilitylbl;
        private Label roomidlbl;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private TextBox txtroomid;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton AddBtn;
        private DataGridView dataGridView1;
    }
}