// Data/SnapNoteContext.cs
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SnapNote.Models;

public class SnapNoteContext : IdentityDbContext
{
    public SnapNoteContext(DbContextOptions<SnapNoteContext> options)
        : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
