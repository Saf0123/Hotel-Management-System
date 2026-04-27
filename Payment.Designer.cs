namespace Hotel_Management_System
{
    partial class Payment
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
            txtbookingid = new TextBox();
            bookingidlbl = new Label();
            txtamount = new TextBox();
            amountlbl = new Label();
            cbpaymentmethod = new ComboBox();
            paymentmethodlbl = new Label();
            rbfailed = new RadioButton();
            rbcompleted = new RadioButton();
            rbpending = new RadioButton();
            bookingstatuslbl = new Label();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            txtpaymentid = new TextBox();
            paymentidlbl = new Label();
            DeleteBtn = new FontAwesome.Sharp.IconButton();
            UpdateBtn = new FontAwesome.Sharp.IconButton();
            AddBtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtbookingid
            // 
            txtbookingid.BackColor = Color.FromArgb(34, 33, 74);
            txtbookingid.Font = new Font("Microsoft Sans Serif", 9F);
            txtbookingid.ForeColor = Color.Gainsboro;
            txtbookingid.Location = new Point(191, 13);
            txtbookingid.Multiline = true;
            txtbookingid.Name = "txtbookingid";
            txtbookingid.Size = new Size(582, 31);
            txtbookingid.TabIndex = 5;
            // 
            // bookingidlbl
            // 
            bookingidlbl.AutoSize = true;
            bookingidlbl.Font = new Font("Segoe UI", 10.2F);
            bookingidlbl.ForeColor = Color.Gainsboro;
            bookingidlbl.Location = new Point(63, 13);
            bookingidlbl.Name = "bookingidlbl";
            bookingidlbl.Size = new Size(103, 23);
            bookingidlbl.TabIndex = 4;
            bookingidlbl.Text = "Booking ID :";
            // 
            // txtamount
            // 
            txtamount.BackColor = Color.FromArgb(34, 33, 74);
            txtamount.Font = new Font("Microsoft Sans Serif", 9F);
            txtamount.ForeColor = Color.Gainsboro;
            txtamount.Location = new Point(191, 59);
            txtamount.Multiline = true;
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(582, 31);
            txtamount.TabIndex = 7;
            // 
            // amountlbl
            // 
            amountlbl.AutoSize = true;
            amountlbl.Font = new Font("Segoe UI", 10.2F);
            amountlbl.ForeColor = Color.Gainsboro;
            amountlbl.Location = new Point(85, 59);
            amountlbl.Name = "amountlbl";
            amountlbl.Size = new Size(81, 23);
            amountlbl.TabIndex = 6;
            amountlbl.Text = "Amount :";
            // 
            // cbpaymentmethod
            // 
            cbpaymentmethod.BackColor = Color.FromArgb(26, 25, 62);
            cbpaymentmethod.Cursor = Cursors.Hand;
            cbpaymentmethod.FlatStyle = FlatStyle.Popup;
            cbpaymentmethod.ForeColor = Color.Gainsboro;
            cbpaymentmethod.FormattingEnabled = true;
            cbpaymentmethod.ItemHeight = 20;
            cbpaymentmethod.Location = new Point(191, 104);
            cbpaymentmethod.Name = "cbpaymentmethod";
            cbpaymentmethod.Size = new Size(582, 28);
            cbpaymentmethod.TabIndex = 10;
            cbpaymentmethod.Text = "Select an option...";
            // 
            // paymentmethodlbl
            // 
            paymentmethodlbl.AutoSize = true;
            paymentmethodlbl.Font = new Font("Segoe UI", 10.2F);
            paymentmethodlbl.ForeColor = Color.Gainsboro;
            paymentmethodlbl.Location = new Point(16, 104);
            paymentmethodlbl.Name = "paymentmethodlbl";
            paymentmethodlbl.Size = new Size(150, 23);
            paymentmethodlbl.TabIndex = 9;
            paymentmethodlbl.Text = "Payment Method :";
            // 
            // rbfailed
            // 
            rbfailed.AutoSize = true;
            rbfailed.Cursor = Cursors.Hand;
            rbfailed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbfailed.ForeColor = Color.Gainsboro;
            rbfailed.Location = new Point(469, 150);
            rbfailed.Name = "rbfailed";
            rbfailed.Size = new Size(71, 24);
            rbfailed.TabIndex = 32;
            rbfailed.Text = "Failed";
            rbfailed.UseVisualStyleBackColor = true;
            // 
            // rbcompleted
            // 
            rbcompleted.AutoSize = true;
            rbcompleted.Cursor = Cursors.Hand;
            rbcompleted.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbcompleted.ForeColor = Color.Gainsboro;
            rbcompleted.Location = new Point(322, 150);
            rbcompleted.Name = "rbcompleted";
            rbcompleted.Size = new Size(106, 24);
            rbcompleted.TabIndex = 31;
            rbcompleted.Text = "Completed";
            rbcompleted.UseVisualStyleBackColor = true;
            // 
            // rbpending
            // 
            rbpending.AutoSize = true;
            rbpending.Checked = true;
            rbpending.Cursor = Cursors.Hand;
            rbpending.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbpending.ForeColor = Color.Gainsboro;
            rbpending.Location = new Point(191, 150);
            rbpending.Name = "rbpending";
            rbpending.Size = new Size(87, 24);
            rbpending.TabIndex = 30;
            rbpending.TabStop = true;
            rbpending.Text = "Pending";
            rbpending.UseVisualStyleBackColor = true;
            // 
            // bookingstatuslbl
            // 
            bookingstatuslbl.AutoSize = true;
            bookingstatuslbl.Font = new Font("Segoe UI", 10.2F);
            bookingstatuslbl.ForeColor = Color.Gainsboro;
            bookingstatuslbl.Location = new Point(34, 150);
            bookingstatuslbl.Name = "bookingstatuslbl";
            bookingstatuslbl.Size = new Size(132, 23);
            bookingstatuslbl.TabIndex = 29;
            bookingstatuslbl.Text = "Booking Status :";
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
            SearchBtn.Location = new Point(322, 193);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 35;
            SearchBtn.Text = "SEARCH";
            SearchBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtpaymentid
            // 
            txtpaymentid.BackColor = Color.FromArgb(34, 33, 74);
            txtpaymentid.Font = new Font("Microsoft Sans Serif", 9F);
            txtpaymentid.ForeColor = Color.Gainsboro;
            txtpaymentid.Location = new Point(191, 191);
            txtpaymentid.Multiline = true;
            txtpaymentid.Name = "txtpaymentid";
            txtpaymentid.Size = new Size(125, 31);
            txtpaymentid.TabIndex = 34;
            // 
            // paymentidlbl
            // 
            paymentidlbl.AutoSize = true;
            paymentidlbl.Font = new Font("Segoe UI", 10.2F);
            paymentidlbl.ForeColor = Color.Gainsboro;
            paymentidlbl.Location = new Point(59, 191);
            paymentidlbl.Name = "paymentidlbl";
            paymentidlbl.Size = new Size(107, 23);
            paymentidlbl.TabIndex = 33;
            paymentidlbl.Text = "Payment ID :";
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
            DeleteBtn.Location = new Point(561, 234);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(103, 29);
            DeleteBtn.TabIndex = 39;
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
            UpdateBtn.Location = new Point(670, 234);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(103, 29);
            UpdateBtn.TabIndex = 38;
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
            AddBtn.Location = new Point(452, 234);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 29);
            AddBtn.TabIndex = 37;
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
            dataGridView1.Location = new Point(40, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 292);
            dataGridView1.TabIndex = 36;
            // 
            // Payment
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
            Controls.Add(txtpaymentid);
            Controls.Add(paymentidlbl);
            Controls.Add(rbfailed);
            Controls.Add(rbcompleted);
            Controls.Add(rbpending);
            Controls.Add(bookingstatuslbl);
            Controls.Add(cbpaymentmethod);
            Controls.Add(paymentmethodlbl);
            Controls.Add(txtamount);
            Controls.Add(amountlbl);
            Controls.Add(txtbookingid);
            Controls.Add(bookingidlbl);
            Name = "Payment";
            Text = "Payment Management";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbookingid;
        private Label bookingidlbl;
        private TextBox txtamount;
        private Label amountlbl;
        private ComboBox cbpaymentmethod;
        private Label paymentmethodlbl;
        private RadioButton rbfailed;
        private RadioButton rbcompleted;
        private RadioButton rbpending;
        private Label bookingstatuslbl;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private TextBox txtpaymentid;
        private Label paymentidlbl;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton UpdateBtn;
        private FontAwesome.Sharp.IconButton AddBtn;
        private DataGridView dataGridView1;
    }
}