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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (cbroomtype.Text == "Select an option...")
                cbroomtype.Text = "";
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbroomtype.Text))
                cbroomtype.Text = "Select an option...";
        }

        private void Room_Load(object sender, EventArgs e)
        {
            // Add room types
            cbroomtype.Items.Clear();
            cbroomtype.Items.AddRange(new string[] { "Single", "Double", "Suite", "Deluxe" });

            LoadRoomData();
        }

        private void LoadRoomData()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Rooms";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthotelid.Text) || cbroomtype.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtppn.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool available = rbyes.Checked;

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Rooms (hotel_id, room_type, price_per_night, availability_status) VALUES (@hotelid, @type, @price, @available)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@hotelid", int.Parse(txthotelid.Text.Trim()));
                    cmd.Parameters.AddWithValue("@type", cbroomtype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtppn.Text.Trim()));
                    cmd.Parameters.AddWithValue("@available", available);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room added successfully.");
                    LoadRoomData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding room: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtroomid.Text))
            {
                MessageBox.Show("Please enter Room ID to update.");
                return;
            }

            bool available = rbyes.Checked;

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Rooms SET hotel_id = @hotelid, room_type = @type, price_per_night = @price, availability_status = @available WHERE room_id = @roomid";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@roomid", int.Parse(txtroomid.Text.Trim()));
                    cmd.Parameters.AddWithValue("@hotelid", int.Parse(txthotelid.Text.Trim()));
                    cmd.Parameters.AddWithValue("@type", cbroomtype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtppn.Text.Trim()));
                    cmd.Parameters.AddWithValue("@available", available);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room updated successfully.");
                    LoadRoomData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating room: " + ex.Message);
                }
            }
        }



        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtroomid.Text) || string.IsNullOrWhiteSpace(txthotelid.Text))
            {
                MessageBox.Show("Please enter both Room ID and Hotel ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Rooms WHERE room_id = @roomid AND hotel_id = @hotelid";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@roomid", int.Parse(txtroomid.Text.Trim()));
                    cmd.Parameters.AddWithValue("@hotelid", int.Parse(txthotelid.Text.Trim()));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room deleted successfully.");
                        LoadRoomData();
                    }
                    else
                    {
                        MessageBox.Show("No matching room found to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting room: " + ex.Message);
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtroomid.Text))
            {
                MessageBox.Show("Please enter Room ID to search.");
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Rooms WHERE room_id = @roomid";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@roomid", int.Parse(txtroomid.Text.Trim()));

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;

                        DataRow row = dt.Rows[0];
                        txthotelid.Text = row["hotel_id"].ToString();
                        cbroomtype.Text = row["room_type"].ToString();
                        txtppn.Text = row["price_per_night"].ToString();
                        bool available = Convert.ToBoolean(row["availability_status"]);
                        rbyes.Checked = available;
                        rbno.Checked = !available;
                    }
                    else
                    {
                        MessageBox.Show("Room not found.");
                        dataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching room: " + ex.Message);
                }
            }
        }

    }
}
