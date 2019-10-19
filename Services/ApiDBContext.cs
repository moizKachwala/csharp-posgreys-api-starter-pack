using Microsoft.EntityFrameworkCore;
using TopCoderStarterApp.Maps;
using TopCoderStarterApp.Models;

namespace TopCoderStarterApp.Services
{
#pragma warning disable CS1591
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options)
       : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Binding the model with database table
            new UserMap(modelBuilder.Entity<User>());
        }
    }
#pragma warning restore CS1591
}