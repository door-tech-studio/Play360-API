using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class QuestionCategoryTypeConfiguration : IEntityTypeConfiguration<QuestionCategoryType>
    {
        public void Configure(EntityTypeBuilder<QuestionCategoryType> builder)
        {
            builder.Property(property => property.Description).IsRequired();

            builder.HasData(
                new QuestionCategoryType()
                {
                    Id = 1,
                    Description = "Physical"
                },
                new QuestionCategoryType()
                {
                    Id = 2,
                    Description = "Mental"
                }
            );

        }
    }
}
