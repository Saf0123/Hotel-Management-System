using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || username == "Username" || password == "Password")
            {
                MessageBox.Show("Please enter a valid username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Check hardcoded admin
            if (username == "admin" && password == "admin123")
            {
                Session.Role = "admin"; // <--- Set session role
                MainMenu main = new MainMenu("admin"); // Ensure MainMenu has constructor with role parameter
                main.Show();
                this.Hide();
                return;
            }

            // 2. Check staff table
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();
                string staffQuery = "SELECT * FROM Staff WHERE name = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(staffQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Session.Role = "staff"; // <--- Set session role
                            MainMenu main = new MainMenu("staff");
                            main.Show();
                            this.Hide();
                            return;
                        }
                    }
                }
            }

            // 3. Check register table
            using (MySqlConnection con = DBConfig.GetConnection())
            {
                con.Open();
                string regQuery = "SELECT * FROM register WHERE username = @username AND password = @password";
                using (MySqlCommand cmd = new MySqlCommand(regQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // REQUIRED to access data
                            Session.RegisterId = Convert.ToInt32(reader["id"]); // Store guest ID from register table
                            Session.Role = "guest"; // Optional but helpful for checks

                            GuestMenu guest = new GuestMenu();
                            guest.Show();
                            this.Hide();
                            return;
                        }
                    }
                }
            }


            // 4. If nothing matched
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword();
            forgotForm.Show();
            this.Hide();
        }
    }
}
