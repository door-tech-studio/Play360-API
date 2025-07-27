using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessBooleanQuestionAnswerConfiguration : IEntityTypeConfiguration<WellnessBooleanQuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<WellnessBooleanQuestionAnswer> builder)
        {
            builder.Property(property => property.WellnessBooleanQuestionId).IsRequired();
            builder.Property(property => property.AnswerText).IsRequired();

            builder
                .HasOne(e => e.WellnessBooleanQuestion)
                .WithMany(e => e.WellnessBooleanQuestionAnswers)
                .HasForeignKey(e => e.WellnessBooleanQuestionId)
                .IsRequired();
        }
    }
}
