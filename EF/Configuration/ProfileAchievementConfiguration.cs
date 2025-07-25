using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileAchievementConfiguration : IEntityTypeConfiguration<ProfileAchievement>
    {
        public void Configure(EntityTypeBuilder<ProfileAchievement> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.Title).IsRequired();
            builder.Property(property => property.Description).IsRequired();
            builder.Property(property => property.AchievementDate).IsRequired();
            builder.Property(property => property.Stat).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileAchievements)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
