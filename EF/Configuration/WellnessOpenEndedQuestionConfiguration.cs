using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessOpenEndedQuestionConfiguration : IEntityTypeConfiguration<WellnessOpenEndedQuestion>
    {
        public void Configure(EntityTypeBuilder<WellnessOpenEndedQuestion> builder)
        {
            builder.Property(property => property.AgeGroupId).IsRequired();
            builder.Property(property => property.FrequencyTypeId).IsRequired();
            builder.Property(property => property.QuestionCategoryId).IsRequired();
            builder.Property(property => property.QuestionText).IsRequired();
            builder.Property(property => property.IsActive).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasMany(e => e.WellnessOpenEndedQuestionResponses)
                .WithOne(e => e.WellnessOpenEndedQuestion)
                .HasForeignKey(e => e.WellnessOpenEndedQuestionId)
                .IsRequired();

            builder.HasData(
                new WellnessOpenEndedQuestion()
                {
                    Id = 1,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 2,
                    QuestionText = "Any mental challenges or stresses today?",
                    CreatedAt = new DateTime(2025, 08, 01, 15, 31, 0),
                },
                new WellnessOpenEndedQuestion()
                {
                    Id = 2,
                    AgeGroupId = 1,
                    FrequencyTypeId = 1,
                    QuestionCategoryId = 1,
                    QuestionText = "What was your biggest challenge this week?",
                    CreatedAt = new DateTime(2025, 08, 01, 15, 31, 0),
                }
            );
        }
    }
}
