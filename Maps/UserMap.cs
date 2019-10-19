
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopCoderStarterApp.Models;


namespace TopCoderStarterApp.Maps
{
#pragma warning disable CS1591
    public class UserMap
    {
        /// <summary>
        /// Mapping of User with database table.
        /// Purpose is if we want to map different keys in database with our object then we can do it.
        /// </summary>
        /// <param name="entityBuilder"></param>
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("users");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Firstname).HasColumnName("firstname");
            entityBuilder.Property(x => x.Lastname).HasColumnName("lastname");
        }
    }
#pragma warning restore CS1591
}