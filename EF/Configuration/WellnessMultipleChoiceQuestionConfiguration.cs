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
        }
    }
}
