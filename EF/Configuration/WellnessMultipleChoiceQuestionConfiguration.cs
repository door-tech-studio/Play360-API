using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessMultipleChoiceQuestionConfiguration : IEntityTypeConfiguration<WellnessMultipleChoiceQuestion>
    {
        public void Configure(EntityTypeBuilder<WellnessMultipleChoiceQuestion> builder)
        {
            builder.Property(property => property.AgeGroupId).IsRequired();
            builder.Property(property => property.FrequencyTypeId).IsRequired();
            builder.Property(property => property.QuestionCategoryId).IsRequired();
            builder.Property(property => property.QuestionText).IsRequired();
            builder.Property(property => property.IsActive).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasMany(e => e.WellnessMultipleChoiceAnswers)
                .WithOne(e => e.WellnessMultipleChoiceQuestion)
                .HasForeignKey(e => e.WellnessMultipleChoiceQuestionId)
                .IsRequired();

            builder.HasData(
                new WellnessMultipleChoiceQuestion() 
                { 
                    Id=1,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 1,
                    QuestionText = "How do you feel today?",
                    CreatedAt = new DateTime(2025, 08, 01, 15, 31, 0),
                },
                new WellnessMultipleChoiceQuestion()
                {
                    Id = 2,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 1,
                    QuestionText = "Do you feel muscle soreness?",
                    CreatedAt = new DateTime(2025, 08, 01, 15, 31, 0),
                },
                new WellnessMultipleChoiceQuestion()
                {
                    Id = 3,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 1,
                    QuestionText = "How did your week feel overall?",
                    CreatedAt = new DateTime(2025, 08, 01, 15, 31, 0),
                }
            );
        }
    }
}
