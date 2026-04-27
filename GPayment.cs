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
    public partial class GPayment : Form
    {
        public GPayment()
        {
            InitializeComponent();
        }

        private void LoadPayments()
        {
            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM Payments WHERE register_id = @registerId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@registerId", Session.RegisterId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }

        private void GPayment_Load(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string paymentId = txtpaymentid.Text.Trim();

            if (string.IsNullOrEmpty(paymentId))
            {
                MessageBox.Show("Please enter a payment ID to search.");
                return;
            }

            try
            {
                using (MySqlConnection con = DBConfig.GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM Payments WHERE register_id = @registerId AND payment_id = @paymentId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@registerId", Session.RegisterId);
                        cmd.Parameters.AddWithValue("@paymentId", paymentId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for payment: " + ex.Message);
            }
        }

    }
}
