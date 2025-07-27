using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessScaleQuestionAnswerConfiguration : IEntityTypeConfiguration<WellnessScaleQuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<WellnessScaleQuestionAnswer> builder)
        {
            builder.Property(property => property.WellnessScaleQuestionId).IsRequired();
            builder.Property(property => property.AnswerText).IsRequired();

            builder
                .HasOne(e => e.WellnessScaleQuestion)
                .WithMany(e => e.WellnessScaleQuestionAnswers)
                .HasForeignKey(e => e.WellnessScaleQuestionId)
                .IsRequired();
        }
    }
}