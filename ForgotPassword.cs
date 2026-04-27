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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter both username and new password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = DBConfig.GetConnection())
            {
                conn.Open();

                // First, try to update in 'register' table
                string checkRegisterQuery = "SELECT * FROM register WHERE username = @username";
                MySqlCommand checkRegisterCmd = new MySqlCommand(checkRegisterQuery, conn);
                checkRegisterCmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = checkRegisterCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Close(); // Must close before executing another command on the same connection

                        string updateRegisterQuery = "UPDATE register SET password = @password WHERE username = @username";
                        MySqlCommand updateRegisterCmd = new MySqlCommand(updateRegisterQuery, conn);
                        updateRegisterCmd.Parameters.AddWithValue("@password", newPassword);
                        updateRegisterCmd.Parameters.AddWithValue("@username", username);

                        updateRegisterCmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated successfully (Guest account).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Try to update in 'staff' table (if not found in 'register')
                string checkStaffQuery = "SELECT * FROM staff WHERE name = @username";
                MySqlCommand checkStaffCmd = new MySqlCommand(checkStaffQuery, conn);
                checkStaffCmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = checkStaffCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Close();

                        string updateStaffQuery = "UPDATE staff SET password = @password WHERE name = @username";
                        MySqlCommand updateStaffCmd = new MySqlCommand(updateStaffQuery, conn);
                        updateStaffCmd.Parameters.AddWithValue("@password", newPassword);
                        updateStaffCmd.Parameters.AddWithValue("@username", username);

                        updateStaffCmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated successfully (Staff account).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // If username not found in either table
                MessageBox.Show("Username not found in guest or staff records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '●';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}
