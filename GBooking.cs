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
    public partial class GBooking : Form
    {
        public GBooking()
        {
            InitializeComponent();
        }

        private void GBooking_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Bookings";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bookings: " + ex.Message);
                }
            }
        }

        private string GetStatus()
        {
            if (rbconfirmed.Checked) return "Confirmed";
            if (rbcancelled.Checked) return "Cancelled";
            if (rbcompleted.Checked) return "Completed";
            return "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO Bookings 
                        (guest_id, room_id, total_price, check_in_date, check_out_date, booking_status, register_id) 
                        VALUES 
                        (@guest_id, @room_id, @total_price, @check_in_date, @check_out_date, @booking_status, @register_id)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@guest_id", txtguestid.Text.Trim());
                    cmd.Parameters.AddWithValue("@room_id", txtroomid.Text.Trim());
                    cmd.Parameters.AddWithValue("@total_price", txttotalprice.Text.Trim());
                    cmd.Parameters.AddWithValue("@check_in_date", dtpcheckindate.Value);
                    cmd.Parameters.AddWithValue("@check_out_date", dtpcheckoutdate.Value);
                    cmd.Parameters.AddWithValue("@booking_status", GetStatus());
                    cmd.Parameters.AddWithValue("@register_id", txtregisterid.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking added successfully.");
                    LoadBookings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding booking: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbookingid.Text))
            {
                MessageBox.Show("Enter Booking ID to update.");
                return;
            }

            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE Bookings SET 
                        guest_id = @guest_id,
                        room_id = @room_id,
                        total_price = @total_price,
                        check_in_date = @check_in_date,
                        check_out_date = @check_out_date,
                        booking_status = @booking_status,
                        register_id = @register_id
                        WHERE booking_id = @booking_id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());
                    cmd.Parameters.AddWithValue("@guest_id", txtguestid.Text.Trim());
                    cmd.Parameters.AddWithValue("@room_id", txtroomid.Text.Trim());
                    cmd.Parameters.AddWithValue("@total_price", txttotalprice.Text.Trim());
                    cmd.Parameters.AddWithValue("@check_in_date", dtpcheckindate.Value);
                    cmd.Parameters.AddWithValue("@check_out_date", dtpcheckoutdate.Value);
                    cmd.Parameters.AddWithValue("@booking_status", GetStatus());
                    cmd.Parameters.AddWithValue("@register_id", txtregisterid.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking updated successfully.");
                    LoadBookings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating booking: " + ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbookingid.Text))
            {
                MessageBox.Show("Enter Booking ID to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"DELETE FROM Bookings WHERE booking_id = @booking_id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking deleted successfully.");
                    LoadBookings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting booking: " + ex.Message);
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Bookings WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(txtbookingid.Text))
                        query += " AND booking_id = @booking_id";
                    if (!string.IsNullOrWhiteSpace(txtguestid.Text))
                        query += " AND guest_id = @guest_id";
                    if (!string.IsNullOrWhiteSpace(txtroomid.Text))
                        query += " AND room_id = @room_id";
                    if (!string.IsNullOrWhiteSpace(txtregisterid.Text))
                        query += " AND register_id = @register_id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    if (!string.IsNullOrWhiteSpace(txtbookingid.Text))
                        cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(txtguestid.Text))
                        cmd.Parameters.AddWithValue("@guest_id", txtguestid.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(txtroomid.Text))
                        cmd.Parameters.AddWithValue("@room_id", txtroomid.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(txtregisterid.Text))
                        cmd.Parameters.AddWithValue("@register_id", txtregisterid.Text.Trim());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching booking: " + ex.Message);
                }
            }
        }
    }
}
