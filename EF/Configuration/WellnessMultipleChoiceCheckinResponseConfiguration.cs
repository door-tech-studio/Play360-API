using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessMultipleChoiceCheckinResponseConfiguration : IEntityTypeConfiguration<WellnessMultipleChoiceCheckinResponse>
    {
        public void Configure(EntityTypeBuilder<WellnessMultipleChoiceCheckinResponse> builder)
        {
            builder.Property(property => property.WellnessMultipleChoiceQuestionId).IsRequired();
            builder.Property(property => property.WellnessMultipleChoiceAnswerId).IsRequired();
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.WellnessCheckinId).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();
            //builder
            //    .HasOne(e => e.WellnessMultipleChoiceQuestion)
            //    .WithMany(e => e.WellnessMultipleChoiceAnswers)
            //    .HasForeignKey(e => e.WellnessMultipleChoiceQuestionId)
            //    .IsRequired();
        }
    }
}
