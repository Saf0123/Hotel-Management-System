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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            cbrole.Items.AddRange(new string[] { "Manager", "Receptionist", "Housekeeping", "Chef", "Security" });
            LoadStaff();
        }

        private void LoadStaff()
        {
            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM Staff";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff records: " + ex.Message);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO Staff (hotel_id, name, role, salary, password) VALUES (@hotel_id, @name, @role, @salary, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@hotel_id", txthotelid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cbrole.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@salary", txtsalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff member added successfully.");
                    LoadStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding staff: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtstaffid.Text))
            {
                MessageBox.Show("Please enter Staff ID to update.");
                return;
            }

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE Staff SET hotel_id = @hotel_id, name = @name, role = @role, salary = @salary, password = @password WHERE staff_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtstaffid.Text.Trim());
                    cmd.Parameters.AddWithValue("@hotel_id", txthotelid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtname.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cbrole.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@salary", txtsalary.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff member updated successfully.");
                    LoadStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff: " + ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtstaffid.Text))
            {
                MessageBox.Show("Please enter Staff ID to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Staff WHERE staff_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtstaffid.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff member deleted successfully.");
                    LoadStaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff: " + ex.Message);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtstaffid.Text) && string.IsNullOrWhiteSpace(txthotelid.Text))
            {
                MessageBox.Show("Please enter Staff ID or Hotel ID to search.");
                return;
            }

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM Staff WHERE staff_id = @staff_id OR hotel_id = @hotel_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@staff_id", txtstaffid.Text.Trim());
                    cmd.Parameters.AddWithValue("@hotel_id", txthotelid.Text.Trim());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching staff: " + ex.Message);
            }
        }
        }
    }
