namespace LibraryManagementApi.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;  // Initialize with a default value
        public string Password { get; set; } = string.Empty;  // Initialize with a default value
        public string Role { get; set; } = string.Empty;      // Initialize with a default value
    }
}
