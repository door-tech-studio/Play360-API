using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(property => property.Email).IsRequired();
            builder.Property(property => property.Password).IsRequired();

            builder
                .HasMany(e => e.Credits)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder
                .HasMany(e => e.Referrals)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.ReffererUserId)
                .IsRequired();

            builder
               .HasMany(e => e.Medias)
               .WithOne(e => e.User)
               .HasForeignKey(e => e.UserId)
               .IsRequired();

            builder
              .HasMany(e => e.WellnessCheckins)
              .WithOne(e => e.User)
              .HasForeignKey(e => e.UserId)
              .IsRequired();

            builder
             .HasMany(e => e.UserAchievements)
             .WithOne(e => e.User)
             .HasForeignKey(e => e.UserId)
             .IsRequired();

            builder
            .HasMany(e => e.WellnessResponses)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithOne(e => e.User)
                .HasForeignKey<Profile>(e => e.UserId)
                .IsRequired();

            builder
            .HasMany(e => e.WellnessWeeklySummaries)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .IsRequired();

            builder
            .HasMany(e => e.Transactions)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .IsRequired();
        }

    }
}
