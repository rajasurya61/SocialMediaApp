using Microsoft.EntityFrameworkCore;

namespace SocialMediaApp.Models
{
    public class SocialMediaDbContext : DbContext
    {
        public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
