namespace SnapNote.Models // Update the namespace
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }  // Foreign key to the post
        public string? Content { get; set; } // Add '?' to make it nullable
        public DateTime CreatedAt { get; set; }

        // Add these fields to link the comment to a user
        public string? UserId { get; set; } // Add '?' to make it nullable
        public string? Username { get; set; } // Add '?' to make it nullable

        public Post? Post { get; set; } // Add '?' to make it nullable
    }
}