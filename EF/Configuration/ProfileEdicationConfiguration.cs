using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileEdicationConfiguration : IEntityTypeConfiguration<ProfileEducation>
    {
        public void Configure(EntityTypeBuilder<ProfileEducation> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.InstitutionName).IsRequired();
            builder.Property(property => property.Degree).IsRequired();
            builder.Property(property => property.StartYear).IsRequired();
            builder.Property(property => property.EndYear).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileEducations)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
