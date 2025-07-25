using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class AchievementTypeConfiguration : IEntityTypeConfiguration<AchievementType>
    {
        public void Configure(EntityTypeBuilder<AchievementType> builder)
        {
            builder.Property(property => property.Id).IsRequired();
            builder.Property(property => property.Description).IsRequired();

        }
    }
}
