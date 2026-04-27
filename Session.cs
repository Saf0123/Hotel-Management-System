using System;

namespace Hotel_Management_System
{
    public static class Session
    {
        // For guests: the ID from the register table
        public static int RegisterId { get; set; }

        // Store the role: "admin", "staff", or "guest"
        public static string Role { get; set; }
    }
}
