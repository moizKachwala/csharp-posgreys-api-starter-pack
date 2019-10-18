using TopCoderStarterApp.Maps;
using Microsoft.EntityFrameworkCore;
using TopCoderStarterApp.Models;
using System;

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
            new UserMap(modelBuilder.Entity<User>());
        }
    }
#pragma warning restore CS1591
}