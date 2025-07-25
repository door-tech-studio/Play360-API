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

        }
    }
}
