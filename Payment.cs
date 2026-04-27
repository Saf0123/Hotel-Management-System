using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cbpaymentmethod.Items.AddRange(new string[] { "Credit Card", "Debit Card", "Cash", "Online Transfer" });
            LoadPayments();
        }

        private void LoadPayments()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Payments";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payments: " + ex.Message);
                }
            }
        }

        private string GetPaymentStatus()
        {
            if (rbpending.Checked) return "Pending";
            if (rbcompleted.Checked) return "Completed";
            if (rbfailed.Checked) return "Failed";
            return "Pending"; // Default
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO Payments (booking_id, amount, payment_method, payment_status) VALUES (@booking_id, @amount, @method, @status)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());
                    cmd.Parameters.AddWithValue("@amount", txtamount.Text.Trim());
                    cmd.Parameters.AddWithValue("@method", cbpaymentmethod.SelectedItem?.ToString() ?? "Cash");
                    cmd.Parameters.AddWithValue("@status", GetPaymentStatus());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment added successfully!");
                    LoadPayments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding payment: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpaymentid.Text))
            {
                MessageBox.Show("Please enter Payment ID to update.");
                return;
            }

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE Payments SET booking_id = @booking_id, amount = @amount, payment_method = @method, payment_status = @status WHERE payment_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtpaymentid.Text.Trim());
                    cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());
                    cmd.Parameters.AddWithValue("@amount", txtamount.Text.Trim());
                    cmd.Parameters.AddWithValue("@method", cbpaymentmethod.SelectedItem?.ToString() ?? "Cash");
                    cmd.Parameters.AddWithValue("@status", GetPaymentStatus());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment updated successfully.");
                    LoadPayments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpaymentid.Text))
            {
                MessageBox.Show("Please enter Payment ID to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this payment?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No) return;

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Payments WHERE payment_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtpaymentid.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment deleted.");
                    LoadPayments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting payment: " + ex.Message);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpaymentid.Text) && string.IsNullOrWhiteSpace(txtbookingid.Text))
            {
                MessageBox.Show("Please enter either Payment ID or Booking ID to search.");
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Payments WHERE 1=1";
                    if (!string.IsNullOrWhiteSpace(txtpaymentid.Text))
                        query += " AND payment_id = @payment_id";
                    if (!string.IsNullOrWhiteSpace(txtbookingid.Text))
                        query += " AND booking_id = @booking_id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (!string.IsNullOrWhiteSpace(txtpaymentid.Text))
                        cmd.Parameters.AddWithValue("@payment_id", txtpaymentid.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(txtbookingid.Text))
                        cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching payment: " + ex.Message);
                }
            }
        }
    }
}
