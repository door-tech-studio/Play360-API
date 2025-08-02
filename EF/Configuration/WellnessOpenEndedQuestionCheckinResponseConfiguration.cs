using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessOpenEndedQuestionCheckinResponseConfiguration : IEntityTypeConfiguration<WellnessOpenEndedQuestionCheckinResponse>
    {
        public void Configure(EntityTypeBuilder<WellnessOpenEndedQuestionCheckinResponse> builder)
        {
            builder.Property(property => property.WellnessOpenEndedQuestionId).IsRequired();
            builder.Property(property => property.AnswerText).IsRequired();
        }
    }
}
