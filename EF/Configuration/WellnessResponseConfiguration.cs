using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessResponseConfiguration : IEntityTypeConfiguration<WellnessResponse>
    {
        public void Configure(EntityTypeBuilder<WellnessResponse> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.QuestionId).IsRequired();
            builder.Property(property => property.ResponseValue).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.WellnessResponses)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder
                .HasOne(e => e.WellnessQuestion)
                .WithMany(e => e.WellnessResponses)
                .HasForeignKey(e => e.QuestionId)
                .IsRequired();

            //builder
            //   .HasOne(e => e.WellnessCheckin)
            //   .WithMany(e => e.WellnessResponses)
            //   .HasForeignKey(e => e.WellnessCheckinId)
            //   .IsRequired();

        }
    }
}
