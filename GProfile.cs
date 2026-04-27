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
using System.Xml.Linq;

namespace Hotel_Management_System
{
    public partial class GProfile : Form
    {
        public GProfile()
        {
            InitializeComponent();
        }
        private void LoadGuestProfile()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM guest_profile WHERE register_id = @registerId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@registerId", Session.RegisterId); // only their own data
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt; // assuming your grid is named dataGridView1
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading guest profile: " + ex.Message);
                }
            }
        }

        private void GProfile_Load(object sender, EventArgs e)
        {
            LoadGuestProfile();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string phone = txtcontact.Text.Trim();
            string address = txtaddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"INSERT INTO guest_profile (register_id, name, email, phone, address) 
                             VALUES (@register_id, @name, @email, @phone, @address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@register_id", Session.RegisterId);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Profile added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGuestProfile(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to add profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtprofileid.Text.Trim(), out int profileId))
            {
                MessageBox.Show("Invalid Profile ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string phone = txtcontact.Text.Trim();
            string address = txtaddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = @"UPDATE guest_profile 
                             SET name = @name, email = @email, phone = @phone, address = @address 
                             WHERE profile_id = @profile_id AND register_id = @register_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@profile_id", profileId);
                        cmd.Parameters.AddWithValue("@register_id", Session.RegisterId);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGuestProfile(); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Make sure the Profile ID is correct and belongs to you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
