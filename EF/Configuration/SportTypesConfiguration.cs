using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class SportTypesConfiguration : IEntityTypeConfiguration<SportTypes>
    {
        public void Configure(EntityTypeBuilder<SportTypes> builder)
        {
            builder.Property(property => property.Id).IsRequired();
            builder.Property(property => property.Description).IsRequired();

            builder.HasData(
                new SportTypes { Id = 1, Description = "Soccer" },
                new SportTypes { Id = 2, Description = "Rugby" },
                new SportTypes { Id = 3, Description = "Cricket" },
                new SportTypes { Id = 4, Description = "Golf" },
                new SportTypes { Id = 5, Description = "Netball" },
                new SportTypes { Id = 6, Description = "Athletics" },
                new SportTypes { Id = 7, Description = "Tennis" },
                new SportTypes { Id = 8, Description = "Swimming" },
                new SportTypes { Id = 9, Description = "Boxing" },
                new SportTypes { Id = 10, Description = "Motorsport" }
            );
        }
    }
} 