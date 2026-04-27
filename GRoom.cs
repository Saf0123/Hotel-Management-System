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
    public partial class GuestRoom : Form
    {
        public GuestRoom()
        {
            InitializeComponent();
        }

        private void GuestRoom_Load(object sender, EventArgs e)
        {
            cbroomtype.Items.AddRange(new string[] { "Single", "Double", "Suite", "Deluxe" });
            cbroomtype.SelectedIndex = 0; // Optional: Set default selection
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string location = txtlocation.Text.Trim();
            string roomType = cbroomtype.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("Please enter a location and select a room type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();

                    string query = @"
                SELECT 
                    Rooms.room_id,
                    Hotels.hotel_name,
                    Hotels.location,
                    Rooms.room_type,
                    Rooms.price_per_night
                FROM Rooms
                INNER JOIN Hotels ON Rooms.hotel_id = Hotels.hotel_id
                WHERE Hotels.location LIKE @location
                  AND Rooms.room_type = @roomType
                  AND Rooms.availability_status = TRUE";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@location", "%" + location + "%");
                        cmd.Parameters.AddWithValue("@roomType", roomType);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rooms: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
