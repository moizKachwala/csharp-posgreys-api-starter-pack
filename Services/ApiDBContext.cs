using dockerapi.Maps;
using Microsoft.EntityFrameworkCore;
using dockerapi.Models;
using System;

namespace dockerapi.Services
{
#pragma warning disable CS1591
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options)
       : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new BlogMap(modelBuilder.Entity<Blog>());
            new UserMap(modelBuilder.Entity<User>());
        }
    }
#pragma warning restore CS1591
}