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
        }
    }
}
