using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.MediaTypeId).IsRequired();
            builder.Property(property => property.URL).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.Medias)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
