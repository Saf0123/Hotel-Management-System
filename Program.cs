using System;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                DBConfig.Connect();
                Application.Run(new Login()); // Continue only if DB connection succeeds
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the database.\n\nError: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // Exit app safely
            }
        }
    }
}
