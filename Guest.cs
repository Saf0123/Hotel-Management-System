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
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            LoadGuestData();
        }

        private void LoadGuestData()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM guest_profile";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading guests: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtguestid.Text))
            {
                MessageBox.Show("Please enter Guest ID to update.");
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE guest_profile SET name = @name, email = @email, phone = @phone, address = @address WHERE profile_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtguestid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtcontact.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest profile updated.");
                    LoadGuestData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating guest: " + ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtguestid.Text))
            {
                MessageBox.Show("Please enter Guest ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM guest_profile WHERE profile_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtguestid.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest profile deleted.");
                    LoadGuestData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting guest: " + ex.Message);
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtguestid.Text))
            {
                MessageBox.Show("Please enter Guest ID to search.");
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM guest_profile WHERE profile_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtguestid.Text.Trim());

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching guest: " + ex.Message);
                }
            }
        }

    }
}
