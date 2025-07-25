using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileReferenceConfiguration : IEntityTypeConfiguration<ProfileReference>
    {
        public void Configure(EntityTypeBuilder<ProfileReference> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.ReferenceName).IsRequired();
            builder.Property(property => property.ContactInfo).IsRequired();
            builder.Property(property => property.Relationship).IsRequired();
            builder.Property(property => property.Role).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileReferences)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
