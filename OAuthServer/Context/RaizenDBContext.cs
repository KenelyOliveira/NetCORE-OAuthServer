using Microsoft.EntityFrameworkCore;
using OAuthServer.Entities;

namespace OAuthServer.Context
{
    public class RaizenDBContext : DbContext
    {
        public RaizenDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
