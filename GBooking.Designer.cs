namespace Hotel_Management_System
{
    partial class GBooking
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
            dataGridView1 = new DataGridView();
            txtguestid = new TextBox();
            dtpcheckoutdate = new DateTimePicker();
            rbcompleted = new RadioButton();
            rbcancelled = new RadioButton();
            rbconfirmed = new RadioButton();
            DeleteBtn = new FontAwesome.Sharp.IconButton();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            txtbookingid = new TextBox();
            bookingidlbl = new Label();
            dtpcheckindate = new DateTimePicker();
            checkoutdatelbl = new Label();
            checkindatelbl = new Label();
            bookingstatuslbl = new Label();
            txttotalprice = new TextBox();
            totalpricelbl = new Label();
            txtroomid = new TextBox();
            roomidlbl = new Label();
            guestidlbl = new Label();
            AddBtn = new FontAwesome.Sharp.IconButton();
            registeridlbl = new Label();
            txtregisterid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 250);
            dataGridView1.TabIndex = 37;
            // 
            // txtguestid
            // 
            txtguestid.BackColor = Color.FromArgb(34, 33, 74);
            txtguestid.Font = new Font("Microsoft Sans Serif", 9F);
            txtguestid.ForeColor = Color.Gainsboro;
            txtguestid.Location = new Point(151, 12);
            txtguestid.Multiline = true;
            txtguestid.Name = "txtguestid";
            txtguestid.Size = new Size(582, 31);
            txtguestid.TabIndex = 56;
            // 
            // dtpcheckoutdate
            // 
            dtpcheckoutdate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpcheckoutdate.CalendarForeColor = Color.DarkBlue;
            dtpcheckoutdate.CalendarMonthBackground = Color.LightYellow;
            dtpcheckoutdate.CalendarTitleBackColor = Color.Teal;
            dtpcheckoutdate.CalendarTitleForeColor = Color.White;
            dtpcheckoutdate.CustomFormat = "dd MMM yyyy";
            dtpcheckoutdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpcheckoutdate.Format = DateTimePickerFormat.Custom;
            dtpcheckoutdate.Location = new Point(544, 159);
            dtpcheckoutdate.Name = "dtpcheckoutdate";
            dtpcheckoutdate.Size = new Size(250, 30);
            dtpcheckoutdate.TabIndex = 55;
            // 
            // rbcompleted
            // 
            rbcompleted.AutoSize = true;
            rbcompleted.Cursor = Cursors.Hand;
            rbcompleted.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbcompleted.ForeColor = Color.Gainsboro;
            rbcompleted.Location = new Point(404, 195);
            rbcompleted.Name = "rbcompleted";
            rbcompleted.Size = new Size(106, 24);
            rbcompleted.TabIndex = 54;
            rbcompleted.Text = "Completed";
            rbcompleted.UseVisualStyleBackColor = true;
            // 
            // rbcancelled
            // 
            rbcancelled.AutoSize = true;
            rbcancelled.Cursor = Cursors.Hand;
            rbcancelled.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbcancelled.ForeColor = Color.Gainsboro;
            rbcancelled.Location = new Point(286, 195);
            rbcancelled.Name = "rbcancelled";
            rbcancelled.Size = new Size(96, 24);
            rbcancelled.TabIndex = 53;
            rbcancelled.Text = "Cancelled";
            rbcancelled.UseVisualStyleBackColor = true;
            // 
            // rbconfirmed
            // 
            rbconfirmed.AutoSize = true;
            rbconfirmed.Checked = true;
            rbconfirmed.Cursor = Cursors.Hand;
            rbconfirmed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbconfirmed.ForeColor = Color.Gainsboro;
            rbconfirmed.Location = new Point(155, 195);
            rbconfirmed.Name = "rbconfirmed";
            rbconfirmed.Size = new Size(104, 24);
            rbconfirmed.TabIndex = 52;
            rbconfirmed.TabStop = true;
            rbconfirmed.Text = "Confirmed";
            rbconfirmed.UseVisualStyleBackColor = true;
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
            DeleteBtn.Location = new Point(556, 276);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(103, 29);
            DeleteBtn.TabIndex = 51;
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
            UpdateBtn.Location = new Point(665, 276);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 50;
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
            SearchBtn.Location = new Point(286, 230);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 49;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtbookingid
            // 
            txtbookingid.BackColor = Color.FromArgb(34, 33, 74);
            txtbookingid.Font = new Font("Microsoft Sans Serif", 9F);
            txtbookingid.ForeColor = Color.Gainsboro;
            txtbookingid.Location = new Point(155, 230);
            txtbookingid.Multiline = true;
            txtbookingid.Name = "txtbookingid";
            txtbookingid.Size = new Size(125, 31);
            txtbookingid.TabIndex = 48;
            // 
            // bookingidlbl
            // 
            bookingidlbl.AutoSize = true;
            bookingidlbl.Font = new Font("Segoe UI", 10.2F);
            bookingidlbl.ForeColor = Color.Gainsboro;
            bookingidlbl.Location = new Point(41, 230);
            bookingidlbl.Name = "bookingidlbl";
            bookingidlbl.Size = new Size(103, 23);
            bookingidlbl.TabIndex = 47;
            bookingidlbl.Text = "Booking ID :";
            // 
            // dtpcheckindate
            // 
            dtpcheckindate.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpcheckindate.CalendarForeColor = Color.DarkBlue;
            dtpcheckindate.CalendarMonthBackground = Color.LightYellow;
            dtpcheckindate.CalendarTitleBackColor = Color.Teal;
            dtpcheckindate.CalendarTitleForeColor = Color.White;
            dtpcheckindate.CustomFormat = "dd MMM yyyy";
            dtpcheckindate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpcheckindate.Format = DateTimePickerFormat.Custom;
            dtpcheckindate.Location = new Point(150, 159);
            dtpcheckindate.Name = "dtpcheckindate";
            dtpcheckindate.Size = new Size(250, 30);
            dtpcheckindate.TabIndex = 46;
            // 
            // checkoutdatelbl
            // 
            checkoutdatelbl.AutoSize = true;
            checkoutdatelbl.Font = new Font("Segoe UI", 10.2F);
            checkoutdatelbl.ForeColor = Color.Gainsboro;
            checkoutdatelbl.Location = new Point(407, 161);
            checkoutdatelbl.Name = "checkoutdatelbl";
            checkoutdatelbl.Size = new Size(137, 23);
            checkoutdatelbl.TabIndex = 45;
            checkoutdatelbl.Text = "Check out Date :";
            // 
            // checkindatelbl
            // 
            checkindatelbl.AutoSize = true;
            checkindatelbl.Font = new Font("Segoe UI", 10.2F);
            checkindatelbl.ForeColor = Color.Gainsboro;
            checkindatelbl.Location = new Point(19, 161);
            checkindatelbl.Name = "checkindatelbl";
            checkindatelbl.Size = new Size(125, 23);
            checkindatelbl.TabIndex = 44;
            checkindatelbl.Text = "Check in Date :";
            // 
            // bookingstatuslbl
            // 
            bookingstatuslbl.AutoSize = true;
            bookingstatuslbl.Font = new Font("Segoe UI", 10.2F);
            bookingstatuslbl.ForeColor = Color.Gainsboro;
            bookingstatuslbl.Location = new Point(12, 196);
            bookingstatuslbl.Name = "bookingstatuslbl";
            bookingstatuslbl.Size = new Size(132, 23);
            bookingstatuslbl.TabIndex = 43;
            bookingstatuslbl.Text = "Booking Status :";
            // 
            // txttotalprice
            // 
            txttotalprice.BackColor = Color.FromArgb(34, 33, 74);
            txttotalprice.Font = new Font("Microsoft Sans Serif", 9F);
            txttotalprice.ForeColor = Color.Gainsboro;
            txttotalprice.Location = new Point(151, 112);
            txttotalprice.Multiline = true;
            txttotalprice.Name = "txttotalprice";
            txttotalprice.Size = new Size(582, 31);
            txttotalprice.TabIndex = 42;
            // 
            // totalpricelbl
            // 
            totalpricelbl.AutoSize = true;
            totalpricelbl.Font = new Font("Segoe UI", 10.2F);
            totalpricelbl.ForeColor = Color.Gainsboro;
            totalpricelbl.Location = new Point(47, 112);
            totalpricelbl.Name = "totalpricelbl";
            totalpricelbl.Size = new Size(97, 23);
            totalpricelbl.TabIndex = 41;
            totalpricelbl.Text = "Total Price :";
            // 
            // txtroomid
            // 
            txtroomid.BackColor = Color.FromArgb(34, 33, 74);
            txtroomid.Font = new Font("Microsoft Sans Serif", 9F);
            txtroomid.ForeColor = Color.Gainsboro;
            txtroomid.Location = new Point(151, 61);
            txtroomid.Multiline = true;
            txtroomid.Name = "txtroomid";
            txtroomid.Size = new Size(582, 31);
            txtroomid.TabIndex = 40;
            // 
            // roomidlbl
            // 
            roomidlbl.AutoSize = true;
            roomidlbl.Font = new Font("Segoe UI", 10.2F);
            roomidlbl.ForeColor = Color.Gainsboro;
            roomidlbl.Location = new Point(58, 61);
            roomidlbl.Name = "roomidlbl";
            roomidlbl.Size = new Size(86, 23);
            roomidlbl.TabIndex = 39;
            roomidlbl.Text = "Room ID :";
            // 
            // guestidlbl
            // 
            guestidlbl.AutoSize = true;
            guestidlbl.Font = new Font("Segoe UI", 10.2F);
            guestidlbl.ForeColor = Color.Gainsboro;
            guestidlbl.Location = new Point(59, 12);
            guestidlbl.Name = "guestidlbl";
            guestidlbl.Size = new Size(85, 23);
            guestidlbl.TabIndex = 38;
            guestidlbl.Text = "Guest ID :";
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
            AddBtn.Location = new Point(447, 276);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 29);
            AddBtn.TabIndex = 57;
            AddBtn.Text = "ADD";
            AddBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // registeridlbl
            // 
            registeridlbl.AutoSize = true;
            registeridlbl.Font = new Font("Segoe UI", 10.2F);
            registeridlbl.ForeColor = Color.Gainsboro;
            registeridlbl.Location = new Point(425, 228);
            registeridlbl.Name = "registeridlbl";
            registeridlbl.Size = new Size(102, 23);
            registeridlbl.TabIndex = 58;
            registeridlbl.Text = "Register ID :";
            // 
            // txtregisterid
            // 
            txtregisterid.BackColor = Color.FromArgb(34, 33, 74);
            txtregisterid.Font = new Font("Microsoft Sans Serif", 9F);
            txtregisterid.ForeColor = Color.Gainsboro;
            txtregisterid.Location = new Point(533, 228);
            txtregisterid.Multiline = true;
            txtregisterid.Name = "txtregisterid";
            txtregisterid.Size = new Size(200, 31);
            txtregisterid.TabIndex = 59;
            // 
            // GBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(txtregisterid);
            Controls.Add(registeridlbl);
            Controls.Add(AddBtn);
            Controls.Add(txtguestid);
            Controls.Add(dtpcheckoutdate);
            Controls.Add(rbcompleted);
            Controls.Add(rbcancelled);
            Controls.Add(rbconfirmed);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(SearchBtn);
            Controls.Add(txtbookingid);
            Controls.Add(bookingidlbl);
            Controls.Add(dtpcheckindate);
            Controls.Add(checkoutdatelbl);
            Controls.Add(checkindatelbl);
            Controls.Add(bookingstatuslbl);
            Controls.Add(txttotalprice);
            Controls.Add(totalpricelbl);
            Controls.Add(txtroomid);
            Controls.Add(roomidlbl);
            Controls.Add(guestidlbl);
            Controls.Add(dataGridView1);
            Name = "GBooking";
            Text = "View Bookings";
            Load += GBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox txtguestid;
        private DateTimePicker dtpcheckoutdate;
        private RadioButton rbcompleted;
        private RadioButton rbcancelled;
        private RadioButton rbconfirmed;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private TextBox txtbookingid;
        private Label bookingidlbl;
        private DateTimePicker dtpcheckindate;
        private Label checkoutdatelbl;
        private Label checkindatelbl;
        private Label bookingstatuslbl;
        private TextBox txttotalprice;
        private Label totalpricelbl;
        private TextBox txtroomid;
        private Label roomidlbl;
        private Label guestidlbl;
        private FontAwesome.Sharp.IconButton AddBtn;
        private Label registeridlbl;
        private TextBox txtregisterid;
    }
}