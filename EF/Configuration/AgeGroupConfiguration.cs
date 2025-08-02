using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class AgeGroupConfiguration : IEntityTypeConfiguration<AgeGroup>
    {
        public void Configure(EntityTypeBuilder<AgeGroup> builder)
        {
            builder.Property(property => property.Description).IsRequired();

            builder.HasData(
                new AgeGroup() 
                {
                    Id = 1, 
                    Description = "All"
                }
            );
        }
    }
}
