using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessScaleQuestionConfiguration : IEntityTypeConfiguration<WellnessScaleQuestion>
    {
        public void Configure(EntityTypeBuilder<WellnessScaleQuestion> builder)
        {
            builder.Property(property => property.AgeGroupId).IsRequired();
            builder.Property(property => property.FrequencyTypeId).IsRequired();
            builder.Property(property => property.QuestionCategoryId).IsRequired();
            builder.Property(property => property.QuestionText).IsRequired();
            builder.Property(property => property.IsActive).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasMany(e => e.WellnessScaleQuestionAnswers)
                .WithOne(e => e.WellnessScaleQuestion)
                .HasForeignKey(e => e.WellnessScaleQuestionId)
                .IsRequired();

            builder.HasData(
                new WellnessScaleQuestion() 
                { 
                    Id = 1,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 1,
                    QuestionText = "How much energy do you have?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestion()
                {
                    Id = 2,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 1,
                    QuestionText = "How well did you sleep last night?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestion()
                {
                    Id = 3,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 2,
                    QuestionText = "How motivated do you feel today ?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestion()
                {
                    Id = 4,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 2,
                    QuestionText = "How focused were you during training today?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                }
            );
        }
    }
}