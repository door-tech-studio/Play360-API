using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessScaleQuestionAnswerConfiguration : IEntityTypeConfiguration<WellnessScaleQuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<WellnessScaleQuestionAnswer> builder)
        {
            builder.Property(property => property.WellnessScaleQuestionId).IsRequired();
            builder.Property(property => property.AnswerText).IsRequired();

            builder.HasData(
                new WellnessScaleQuestionAnswer() 
                { 
                    Id = 1,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "1",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 2,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "2",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 3,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "3",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 4,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "4",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 5,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "5",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 6,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "6",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 7,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "7",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 8,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "8",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 9,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "9",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 10,
                    WellnessScaleQuestionId = 1,
                    AnswerText = "10",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },

                new WellnessScaleQuestionAnswer()
                {
                    Id = 11,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "1",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 12,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "2",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 13,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "3",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 14,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "4",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 15,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "5",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 16,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "6",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 17,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "7",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 18,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "8",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 19,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "9",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 20,
                    WellnessScaleQuestionId = 2,
                    AnswerText = "10",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },

                new WellnessScaleQuestionAnswer()
                {
                    Id = 21,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "1",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 22,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "2",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 23,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "3",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 24,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "4",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 25,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "5",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 26,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "6",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 27,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "7",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 28,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "8",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 29,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "9",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 30,
                    WellnessScaleQuestionId = 3,
                    AnswerText = "10",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },


                new WellnessScaleQuestionAnswer()
                {
                    Id = 31,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "1",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 32,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "2",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 33,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "3",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 34,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "4",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 35,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "5",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 36,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "6",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 37,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "7",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 38,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "8",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 39,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "9",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                },
                new WellnessScaleQuestionAnswer()
                {
                    Id = 40,
                    WellnessScaleQuestionId = 4,
                    AnswerText = "10",
                    CreatedAt = new DateTime(2025, 08, 02, 08, 58, 0)
                }
            );

            //builder
            //    .HasOne(e => e.WellnessScaleQuestion)
            //    .WithMany(e => e.WellnessScaleQuestionAnswers)
            //    .HasForeignKey(e => e.WellnessScaleQuestionId)
            //    .IsRequired();
        }
    }
}