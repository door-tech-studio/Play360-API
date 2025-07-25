using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileCertificateConfiguration : IEntityTypeConfiguration<ProfileCertificate>
    {
        public void Configure(EntityTypeBuilder<ProfileCertificate> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.CertificationName).IsRequired();
            builder.Property(property => property.Institution).IsRequired();
            builder.Property(property => property.Date).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileCertificates)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
