using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class MediaTypeConfiguration : IEntityTypeConfiguration<MediaType>
    {
        public void Configure(EntityTypeBuilder<MediaType> builder)
        {
            builder.Property(property => property.Id).IsRequired();
            builder.Property(property => property.Description).IsRequired();

        }
    }
}