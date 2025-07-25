using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class UserAchievementConfiguration : IEntityTypeConfiguration<UserAchievement>
    {
        public void Configure(EntityTypeBuilder<UserAchievement> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.AchievementTypeId).IsRequired();
            builder.Property(property => property.Value).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.UserAchievements)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
