
using TopCoderStarterApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace TopCoderStarterApp.Maps{
    #pragma warning disable CS1591
       public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("Users");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Firstname).HasColumnName("firstname");
            entityBuilder.Property(x => x.Lastname).HasColumnName("lastname");
        }
    }
    #pragma warning restore CS1591
}