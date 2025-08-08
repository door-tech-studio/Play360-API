using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class UserSportConfiguration : IEntityTypeConfiguration<UserSport>
    {
        public void Configure(EntityTypeBuilder<UserSport> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.SportTypeId).IsRequired();
            builder.Property(property => property.Position).IsRequired();
            builder.Property(property => property.DominantSideId).IsRequired();

            builder.HasKey(property => new { property.UserId, property.SportTypeId });

            builder.HasOne(property => property.User)
                .WithMany(user => user.UserSports)
                .HasForeignKey(property => property.UserId)
                .IsRequired();

            builder.HasOne(property => property.SportType)
                .WithMany(sport => sport.UserSports)
                .HasForeignKey(property => property.SportTypeId)
                .IsRequired();
        }
    }
}