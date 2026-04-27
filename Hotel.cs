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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }
        private void txtContact_Enter(object sender, EventArgs e)
        {
            if (txtcontact.Text == "03**-*******")
            {
                txtcontact.Text = "";
                txtcontact.ForeColor = Color.Gainsboro;
            }
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcontact.Text))
            {
                txtcontact.Text = "03**-*******";
                txtcontact.ForeColor = Color.Gainsboro;
            }
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            // Populate star ratings
            cbstarrating.Items.Clear();
            for (int i = 1; i <= 5; i++)
                cbstarrating.Items.Add(i.ToString());

            LoadHotels();
        }

        private void LoadHotels()
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Hotels";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading hotels: " + ex.Message);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Hotels (hotel_name, location, contact_info, star_rating) VALUES (@name, @location, @contact, @rating)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", txtlocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtcontact.Text.Trim());
                    cmd.Parameters.AddWithValue("@rating", int.Parse(cbstarrating.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hotel added successfully.");
                    LoadHotels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding hotel: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthotelid.Text))
            {
                MessageBox.Show("Enter Hotel ID to update.");
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Hotels SET hotel_name = @name, location = @location, contact_info = @contact, star_rating = @rating WHERE hotel_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", txtlocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtcontact.Text.Trim());
                    cmd.Parameters.AddWithValue("@rating", int.Parse(cbstarrating.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(txthotelid.Text.Trim()));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Hotel updated successfully.");
                        LoadHotels();
                    }
                    else
                    {
                        MessageBox.Show("No hotel found with that ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating hotel: " + ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthotelid.Text))
            {
                MessageBox.Show("Enter Hotel ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this hotel?", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Hotels WHERE hotel_id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", int.Parse(txthotelid.Text.Trim()));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Hotel deleted successfully.");
                            LoadHotels();
                        }
                        else
                        {
                            MessageBox.Show("No hotel found with that ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting hotel: " + ex.Message);
                    }
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthotelid.Text))
            {
                MessageBox.Show("Please enter a Hotel ID to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Hotels WHERE hotel_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txthotelid.Text.Trim()));

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;

                        // Optional: auto-fill form fields with data
                        DataRow row = dt.Rows[0];
                        txtname.Text = row["hotel_name"].ToString();
                        txtlocation.Text = row["location"].ToString();
                        txtcontact.Text = row["contact_info"].ToString();
                        cbstarrating.Text = row["star_rating"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hotel found with that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching hotel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
