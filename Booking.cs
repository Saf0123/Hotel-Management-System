using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Hotel_Management_System
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM Bookings";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string status = rbconfirmed.Checked ? "Confirmed" : rbcancelled.Checked ? "Cancelled" : "Completed";
                    string query = @"UPDATE Bookings 
                             SET guest_id = @guest_id, room_id = @room_id, check_in_date = @checkin, check_out_date = @checkout,
                                 total_price = @price, booking_status = @status
                             WHERE booking_id = @booking_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@guest_id", txtguestid.Text);
                        cmd.Parameters.AddWithValue("@room_id", txtroomid.Text);
                        cmd.Parameters.AddWithValue("@checkin", dtpcheckindate.Value.Date);
                        cmd.Parameters.AddWithValue("@checkout", dtpcheckoutdate.Value.Date);
                        cmd.Parameters.AddWithValue("@price", txttotalprice.Text);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Booking updated successfully.");
                        else
                            MessageBox.Show("Booking not found.");
                        LoadBookings();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = DBConfig.GetConnection())
                    {
                        con.Open();
                        string query = "DELETE FROM Bookings WHERE booking_id = @booking_id AND guest_id = @guest_id AND room_id = @room_id";

                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text);
                            cmd.Parameters.AddWithValue("@guest_id", txtguestid.Text);
                            cmd.Parameters.AddWithValue("@room_id", txtroomid.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                                MessageBox.Show("Booking deleted successfully.");
                            else
                                MessageBox.Show("Booking not found.");
                            LoadBookings();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting booking: " + ex.Message);
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT * FROM Bookings 
                             WHERE booking_id = @booking_id OR guest_id = @guest_id OR room_id = @room_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text);
                        cmd.Parameters.AddWithValue("@guest_id", txtguestid.Text);
                        cmd.Parameters.AddWithValue("@room_id", txtroomid.Text);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching booking: " + ex.Message);
            }
        }
    }

}
