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

            builder.HasData(
                new WellnessBooleanQuestionAnswer() 
                { 
                    Id = 1,
                    WellnessBooleanQuestionId = 1,
                    AnswerText = "True",
                },
                new WellnessBooleanQuestionAnswer()
                {
                    Id = 2,
                    WellnessBooleanQuestionId = 1,
                    AnswerText = "False",
                },
                new WellnessBooleanQuestionAnswer()
                {
                    Id = 3,
                    WellnessBooleanQuestionId = 2,
                    AnswerText = "True",
                },
                new WellnessBooleanQuestionAnswer()
                {
                    Id = 4,
                    WellnessBooleanQuestionId = 2,
                    AnswerText = "False",
                },
                new WellnessBooleanQuestionAnswer()
                {
                    Id = 5,
                    WellnessBooleanQuestionId = 3,
                    AnswerText = "True",
                },
                new WellnessBooleanQuestionAnswer()
                {
                    Id = 6,
                    WellnessBooleanQuestionId = 3,
                    AnswerText = "False",
                },
                new WellnessBooleanQuestionAnswer()
                {
                    Id = 7,
                    WellnessBooleanQuestionId = 4,
                    AnswerText = "True",
                },
                new WellnessBooleanQuestionAnswer()
                {
                    Id = 8,
                    WellnessBooleanQuestionId = 4,
                    AnswerText = "False",
                }
            );

            //builder
            //    .HasOne(e => e.WellnessBooleanQuestion)
            //    .WithMany(e => e.WellnessBooleanQuestionAnswers)
            //    .HasForeignKey(e => e.WellnessBooleanQuestionId)
            //    .IsRequired();
        }
    }
}
