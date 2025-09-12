using Microsoft.EntityFrameworkCore;

namespace BlazorPlayground.Infrastructure.Data.DbContexts.Contexts.Implementation
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}