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
        }
    }
}