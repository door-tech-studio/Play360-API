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
           
            //builder
            //    .HasOne(e => e.WellnessMultipleChoiceQuestion)
            //    .WithMany(e => e.WellnessMultipleChoiceAnswers)
            //    .HasForeignKey(e => e.WellnessMultipleChoiceQuestionId)
            //    .IsRequired();

            builder.HasData(
                new WellnessMultipleChoiceAnswer 
                { 
                    Id = 1, 
                    WellnessMultipleChoiceQuestionId = 1, 
                    AnswerText = "Good" 
                },
                 new WellnessMultipleChoiceAnswer
                 {
                     Id = 2,
                     WellnessMultipleChoiceQuestionId = 1,
                     AnswerText = "Okay"
                 },
                new WellnessMultipleChoiceAnswer
                {
                    Id = 3,
                    WellnessMultipleChoiceQuestionId = 1,
                    AnswerText = "Bad"
                },

                new WellnessMultipleChoiceAnswer
                {
                    Id = 4,
                    WellnessMultipleChoiceQuestionId = 2,
                    AnswerText = "Good"
                },
                 new WellnessMultipleChoiceAnswer
                 {
                     Id = 5,
                     WellnessMultipleChoiceQuestionId = 2,
                     AnswerText = "Okay"
                 },
                new WellnessMultipleChoiceAnswer
                {
                    Id = 6,
                    WellnessMultipleChoiceQuestionId = 2,
                    AnswerText = "Bad"
                },

                new WellnessMultipleChoiceAnswer
                {
                    Id = 7,
                    WellnessMultipleChoiceQuestionId = 3,
                    AnswerText = "Good"
                },
                 new WellnessMultipleChoiceAnswer
                 {
                     Id = 8,
                     WellnessMultipleChoiceQuestionId = 3,
                     AnswerText = "Okay"
                 },
                new WellnessMultipleChoiceAnswer
                {
                    Id = 9,
                    WellnessMultipleChoiceQuestionId = 3,
                    AnswerText = "Bad"
                }
            );
        }
    }
}
