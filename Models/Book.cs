namespace LibraryManagementApi.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 
        public string Title { get; set; } = string.Empty;  // Initialize with a default value
        public string Author { get; set; } = string.Empty; // Initialize with a default value
        public string ISBN { get; set; } = string.Empty;   // Initialize with a default value
        public bool IsAvailable { get; set; } = true;      // Default value
        public DateTime? BorrowedUntil { get; set; }       // Nullable because it can be null if not borrowed
    }
}
