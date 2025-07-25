using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileMedicalInfoConfiguration : IEntityTypeConfiguration<ProfileMedicalInfo>
    {
        public void Configure(EntityTypeBuilder<ProfileMedicalInfo> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.MedicalNote).IsRequired();
            builder.Property(property => property.InjuryHistory).IsRequired();
            builder.Property(property => property.DoctorName).IsRequired();
            builder.Property(property => property.DoctorContact).IsRequired();
            builder.Property(property => property.MedicalAidProvider).IsRequired();
            builder.Property(property => property.MedicalAidNumber).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileMedicalInfos)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
