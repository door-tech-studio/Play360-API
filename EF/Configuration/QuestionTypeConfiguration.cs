using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class QuestionTypeConfiguration : IEntityTypeConfiguration<QuestionType>
    {
        public void Configure(EntityTypeBuilder<QuestionType> builder)
        {
            builder.Property(property => property.Id).IsRequired();
            builder.Property(property => property.Description).IsRequired();

        }
    }
}
