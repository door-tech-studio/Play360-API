using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessBooleanQuestionConfiguration : IEntityTypeConfiguration<WellnessBooleanQuestion>
    {
        public void Configure(EntityTypeBuilder<WellnessBooleanQuestion> builder)
        {
            builder.Property(property => property.AgeGroupId).IsRequired();
            builder.Property(property => property.FrequencyTypeId).IsRequired();
            builder.Property(property => property.QuestionCategoryId).IsRequired();
            builder.Property(property => property.QuestionText).IsRequired();
            builder.Property(property => property.IsActive).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasMany(e => e.WellnessBooleanQuestionAnswers)
                .WithOne(e => e.WellnessBooleanQuestion)
                .HasForeignKey(e => e.WellnessBooleanQuestionId)
                .IsRequired();

            builder.HasData(
                new WellnessBooleanQuestion() 
                {
                    Id = 1,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 1,
                    QuestionText = "Do you have any injuries or pain?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0),
                },
                new WellnessBooleanQuestion()
                {
                    Id = 2,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 2,
                    QuestionText = "Do you feel mentally exhausted?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0),
                },
                new WellnessBooleanQuestion()
                {
                    Id = 3,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 2,
                    QuestionText = "Did you practice mindfulness today?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0),
                },
                new WellnessBooleanQuestion()
                {
                    Id = 4,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 2,
                    QuestionText = "Any injuries or stress this week?",
                    IsActive = true,
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0),
                }

            );
        }
    }
}
