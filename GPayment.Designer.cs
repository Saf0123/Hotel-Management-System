namespace Hotel_Management_System
{
    partial class GPayment
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
            SearchBtn = new FontAwesome.Sharp.IconButton();
            txtpaymentid = new TextBox();
            paymentidlbl = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            SearchBtn.Location = new Point(298, 31);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(103, 29);
            SearchBtn.TabIndex = 38;
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
            txtpaymentid.Location = new Point(167, 31);
            txtpaymentid.Multiline = true;
            txtpaymentid.Name = "txtpaymentid";
            txtpaymentid.Size = new Size(125, 31);
            txtpaymentid.TabIndex = 37;
            // 
            // paymentidlbl
            // 
            paymentidlbl.AutoSize = true;
            paymentidlbl.Font = new Font("Segoe UI", 10.2F);
            paymentidlbl.ForeColor = Color.Gainsboro;
            paymentidlbl.Location = new Point(53, 31);
            paymentidlbl.Name = "paymentidlbl";
            paymentidlbl.Size = new Size(107, 23);
            paymentidlbl.TabIndex = 36;
            paymentidlbl.Text = "Payment ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 483);
            dataGridView1.TabIndex = 39;
            // 
            // GPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(803, 573);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(txtpaymentid);
            Controls.Add(paymentidlbl);
            Name = "GPayment";
            Text = "View Payments";
            Load += GPayment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton SearchBtn;
        private TextBox txtpaymentid;
        private Label paymentidlbl;
        private DataGridView dataGridView1;
    }
}