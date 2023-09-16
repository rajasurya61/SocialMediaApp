using Microsoft.EntityFrameworkCore;
using SocialMediaApp.Models;

namespace SocialMediaApp
{
    public class SocialMediaDbContext : DbContext
    {
        public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options): base(options){}

        public DbSet<User> Users { get; set; }
    }
}
