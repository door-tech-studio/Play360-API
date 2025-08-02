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

            builder.HasData(
                new User {
                    Id = 2,
                    Email = "bsngema7@gmail.com", 
                    Password = "12345", 
                    FirstName = "Bongi",
                    LastName = "Ngema", 
                    IsPopiAccepting = true, 
                    CreatedAt = new DateTime(2025, 08, 01, 14, 30, 0), 
                    UpdatedAt= new DateTime(2025, 08, 01, 14, 30, 0), 
                    IdentityNumber="9003205674083",
                    ReferralCode="AaBbCc"
                },
                new User
                {
                    Id = 3,
                    Email = "yenzom@icloud.com",
                    Password = "12345",
                    FirstName = "Yenzo",
                    LastName = "Mdladla",
                    IsPopiAccepting = true,
                    CreatedAt = new DateTime(2025, 08, 01, 14, 30, 0),
                    UpdatedAt = new DateTime(2025, 08, 01, 14, 30, 0),
                    IdentityNumber = "9003205674083",
                    ReferralCode = "BbCcDd"
                },
                 new User
                 {
                     Id = 4,
                     Email = "stephen@icloud.com",
                     Password = "12345",
                     FirstName = "Stephen",
                     LastName = "Engelbrecht",
                     IsPopiAccepting = true,
                     CreatedAt = new DateTime(2025, 08, 01, 14, 30, 0),
                     UpdatedAt = new DateTime(2025, 08, 01, 14, 30, 0),
                     IdentityNumber = "9003205674083",
                     ReferralCode = "CcDdEe"
                 },
                  new User
                  {
                      Id = 5,
                      Email = "ndlovumpilo@icloud.com",
                      Password = "12345",
                      FirstName = "Mpilo",
                      LastName = "Ndlovu",
                      IsPopiAccepting = true,
                      CreatedAt = new DateTime(2025, 08, 01, 14, 30, 0),
                      UpdatedAt = new DateTime(2025, 08, 01, 14, 30, 0),
                      IdentityNumber = "9003205674083",
                      ReferralCode = "DdEeFe"
                  }
            );
        }

    }
}
