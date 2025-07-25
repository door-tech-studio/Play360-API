using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessCheckinConfiguration : IEntityTypeConfiguration<WellnessCheckin>
    {
        public void Configure(EntityTypeBuilder<WellnessCheckin> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.FeelingType).IsRequired();
            builder.Property(property => property.IsInjured).IsRequired();
            builder.Property(property => property.Notes).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.WellnessCheckins)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            //builder
            //    .HasMany(e => e.WellnessResponses)
            //    .WithOne(e => e.WellnessCheckin)
            //    .HasForeignKey(e => e.WellnessCheckinId)
            //    .IsRequired(); 
        }
    }
}
