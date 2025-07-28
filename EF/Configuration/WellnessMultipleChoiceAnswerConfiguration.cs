using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessMultipleChoiceAnswerConfiguration : IEntityTypeConfiguration<WellnessMultipleChoiceAnswer>
    {
        public void Configure(EntityTypeBuilder<WellnessMultipleChoiceAnswer> builder)
        {
            builder.Property(property => property.WellnessMultipleChoiceQuestionId).IsRequired();
            builder.Property(property => property.AnswerText).IsRequired();
           
            builder
                .HasOne(e => e.WellnessMultipleChoiceQuestion)
                .WithMany(e => e.WellnessMultipleChoiceAnswers)
                .HasForeignKey(e => e.WellnessMultipleChoiceQuestionId)
                .IsRequired();
        }
    }
}
