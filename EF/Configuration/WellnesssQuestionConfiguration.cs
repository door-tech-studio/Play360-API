using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnesssQuestionConfiguration : IEntityTypeConfiguration<WellnessQuestion>
    {
        public void Configure(EntityTypeBuilder<WellnessQuestion> builder)
        {
            builder.Property(property => property.QuestionTypeId).IsRequired();
            builder.Property(property => property.QuestionText).IsRequired();
            builder.Property(property => property.IsActive).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
              .HasMany(e => e.WellnessResponses)
              .WithOne(e => e.WellnessQuestion)
              .HasForeignKey(e => e.QuestionId)
              .IsRequired();
        }
    }
}
