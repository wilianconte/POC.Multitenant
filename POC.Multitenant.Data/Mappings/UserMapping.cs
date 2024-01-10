using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POC.Multitenant.Data.Seeds;
using POC.Multitenant.Domain.Entities;

namespace POC.Multitenant.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public UserMapping() 
        {
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired();

            //Add Seed
            builder.HasData(UserSeed.Data);
        }
    }
}
