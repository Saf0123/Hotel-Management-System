using System;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    internal static class DBConfig
    {
        // Connection string to your MySQL database
        private static readonly string connectionString =
            "server=localhost;user id=root;password=Mitsuha151323;database=hotelmanagement;";

        // Shared connection used for testing at startup
        public static MySqlConnection Connection { get; private set; }

        /// <summary>
        /// Test method to open the shared connection at startup
        /// </summary>
        public static void Connect()
        {
            try
            {
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
                Console.WriteLine("✅ Database connection established.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error connecting to database: " + ex.Message);
                throw; // Re-throw to handle in Program.cs
            }
        }

        /// <summary>
        /// Cleanly closes the shared connection
        /// </summary>
        public static void Disconnect()
        {
            if (Connection != null && Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
                Console.WriteLine("ℹ️ Database connection closed.");
            }
        }

        /// <summary>
        /// Provides a new MySqlConnection for normal usage
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}


