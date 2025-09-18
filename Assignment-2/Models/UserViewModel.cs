namespace Event_Management_System.Models
{
    public class UserViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public int UserType { get; set; } // 1, 2, 3, 4

        // Helper property → converts number to text
        public string UserTypeText
        {
            get
            {
                return UserType switch
                {
                    1 => "Admin User",
                    2 => "Standard User",
                    3 => "External User",
                    4 => "Guest User",
                    _ => "Unknown"
                };
            }
        }
    }
}

