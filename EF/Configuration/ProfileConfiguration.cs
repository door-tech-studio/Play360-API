using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.SportTypeId).IsRequired();
            builder.Property(property => property.Position).IsRequired();
            builder.Property(property => property.Height).IsRequired();
            builder.Property(property => property.Weight).IsRequired();
            builder.Property(property => property.DominantSideId).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();
            builder.Property(property => property.UpdatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithOne(e => e.Profile)
                .HasForeignKey<Profile>(e => e.UserId)
                .IsRequired();

            builder
                .HasMany(e => e.ProfileEducations)
                .WithOne(e => e.Profile)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();

            builder
            .HasMany(e => e.ProfileTeams)
            .WithOne(e => e.Profile)
            .HasForeignKey(e => e.ProfileId)
            .IsRequired();

            builder
                .HasMany(e => e.ProfileSkills)
                .WithOne(e => e.Profile)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();

            builder
                .HasMany(e => e.ProfileReferences)
                .WithOne(e => e.Profile)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();

            builder
                .HasMany(e => e.ProfileAchievements)
                .WithOne(e => e.Profile)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();

            builder
                .HasMany(e => e.ProfileCertificates)
                .WithOne(e => e.Profile)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();

            builder
               .HasMany(e => e.ProfileGoals)
               .WithOne(e => e.Profile)
               .HasForeignKey(e => e.ProfileId)
               .IsRequired();

            builder
               .HasMany(e => e.ProfileMedicalInfos)
               .WithOne(e => e.Profile)
               .HasForeignKey(e => e.ProfileId)
               .IsRequired();
        }
    }
}
