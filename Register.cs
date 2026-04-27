using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || username == "Username" || password == "Password")
            {
                MessageBox.Show(" Please enter both a valid username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConfig.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO register (username, password) VALUES (@username, @password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // In production, hash the password

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to Login form
                            Login loginForm = new Login();
                            loginForm.Show();
                            this.Hide(); // Or use this.Close(); to dispose
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Application.Exit();
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
