using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class DominentSideConfiguration : IEntityTypeConfiguration<DominantSide>
    {
        public void Configure(EntityTypeBuilder<DominantSide> builder)
        {
            builder.Property(property => property.Id).IsRequired();
            builder.Property(property => property.Description).IsRequired();

            builder.HasData(
                new DominantSide { Id = 1, Description = "Right" },
                new DominantSide { Id = 2, Description = "Left" },
                new DominantSide { Id = 3, Description = "Ambidextrous" }
            );
        }
    }
}
