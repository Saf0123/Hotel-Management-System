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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            LoadServices();
            PopulateServiceTypes();
        }

        private void PopulateServiceTypes()
        {
            cbservicetype.Items.Clear();
            cbservicetype.Items.Add("Room Cleaning");
            cbservicetype.Items.Add("Food Delivery");
            cbservicetype.Items.Add("Laundry");
            cbservicetype.Items.Add("Spa");
            cbservicetype.Items.Add("Taxi");
            cbservicetype.SelectedIndex = 0;
        }

        private void LoadServices()
        {
            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Services";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services: " + ex.Message);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Services (booking_id, service_type, service_charge) VALUES (@booking_id, @service_type, @service_charge)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());
                    cmd.Parameters.AddWithValue("@service_type", cbservicetype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@service_charge", txtservicecharge.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service added successfully.");
                    LoadServices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding service: " + ex.Message);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtserviceid.Text) || string.IsNullOrWhiteSpace(txtbookingid.Text))
            {
                MessageBox.Show("Please enter Service ID and Booking ID to update.");
                return;
            }

            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Services SET service_type = @service_type, service_charge = @service_charge WHERE service_id = @service_id AND booking_id = @booking_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@service_id", txtserviceid.Text.Trim());
                    cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());
                    cmd.Parameters.AddWithValue("@service_type", cbservicetype.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@service_charge", txtservicecharge.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service updated successfully.");
                    LoadServices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating service: " + ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtserviceid.Text) || string.IsNullOrWhiteSpace(txtbookingid.Text))
            {
                MessageBox.Show("Please enter Service ID and Booking ID to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            using (var con = DBConfig.GetConnection())
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Services WHERE service_id = @service_id AND booking_id = @booking_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@service_id", txtserviceid.Text.Trim());
                    cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Service deleted successfully.");
                    LoadServices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting service: " + ex.Message);
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
                    string query = "SELECT * FROM Services WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(txtserviceid.Text))
                        query += " AND service_id = @service_id";
                    if (!string.IsNullOrWhiteSpace(txtbookingid.Text))
                        query += " AND booking_id = @booking_id";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (!string.IsNullOrWhiteSpace(txtserviceid.Text))
                        cmd.Parameters.AddWithValue("@service_id", txtserviceid.Text.Trim());
                    if (!string.IsNullOrWhiteSpace(txtbookingid.Text))
                        cmd.Parameters.AddWithValue("@booking_id", txtbookingid.Text.Trim());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching service: " + ex.Message);
                }
            }
        }
    }
}
