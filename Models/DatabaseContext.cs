using Microsoft.EntityFrameworkCore;

namespace PhotoGallery.Models;
 public class DatabaseContext : DbContext
{
    public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    public DbSet<Photo> Photo { get; set; } = null!;
}
