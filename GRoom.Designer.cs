namespace Hotel_Management_System
{
    partial class GuestRoom
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
            txtlocation = new TextBox();
            locationlbl = new Label();
            cbroomtype = new ComboBox();
            roomtypelbl = new Label();
            dataGridView1 = new DataGridView();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtlocation
            // 
            txtlocation.BackColor = Color.FromArgb(34, 33, 74);
            txtlocation.Font = new Font("Microsoft Sans Serif", 9F);
            txtlocation.ForeColor = Color.Gainsboro;
            txtlocation.Location = new Point(162, 23);
            txtlocation.Multiline = true;
            txtlocation.Name = "txtlocation";
            txtlocation.ScrollBars = ScrollBars.Vertical;
            txtlocation.Size = new Size(582, 52);
            txtlocation.TabIndex = 6;
            // 
            // locationlbl
            // 
            locationlbl.AutoSize = true;
            locationlbl.Font = new Font("Segoe UI", 10.2F);
            locationlbl.ForeColor = Color.Gainsboro;
            locationlbl.Location = new Point(53, 23);
            locationlbl.Name = "locationlbl";
            locationlbl.Size = new Size(84, 23);
            locationlbl.TabIndex = 5;
            locationlbl.Text = "Location :";
            // 
            // cbroomtype
            // 
            cbroomtype.BackColor = Color.FromArgb(26, 25, 62);
            cbroomtype.Cursor = Cursors.Hand;
            cbroomtype.FlatStyle = FlatStyle.Popup;
            cbroomtype.ForeColor = Color.Gainsboro;
            cbroomtype.FormattingEnabled = true;
            cbroomtype.ItemHeight = 20;
            cbroomtype.Location = new Point(162, 93);
            cbroomtype.Name = "cbroomtype";
            cbroomtype.Size = new Size(582, 28);
            cbroomtype.TabIndex = 10;
            cbroomtype.Text = "Select an option...";
            // 
            // roomtypelbl
            // 
            roomtypelbl.AutoSize = true;
            roomtypelbl.Font = new Font("Segoe UI", 10.2F);
            roomtypelbl.ForeColor = Color.Gainsboro;
            roomtypelbl.Location = new Point(33, 93);
            roomtypelbl.Name = "roomtypelbl";
            roomtypelbl.Size = new Size(104, 23);
            roomtypelbl.TabIndex = 9;
            roomtypelbl.Text = "Room Type :";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 376);
            dataGridView1.TabIndex = 16;
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
            SearchBtn.Location = new Point(663, 150);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 17;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // GuestRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(SearchBtn);
            Controls.Add(dataGridView1);
            Controls.Add(cbroomtype);
            Controls.Add(roomtypelbl);
            Controls.Add(txtlocation);
            Controls.Add(locationlbl);
            Name = "GuestRoom";
            Text = "View Rooms";
            Load += GuestRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlocation;
        private Label locationlbl;
        private ComboBox cbroomtype;
        private Label roomtypelbl;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton SearchBtn;
    }
}