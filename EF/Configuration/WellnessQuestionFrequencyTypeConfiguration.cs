using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessQuestionFrequencyTypeConfiguration : IEntityTypeConfiguration<WellnessQuestionFrequencyType>
    {
        public void Configure(EntityTypeBuilder<WellnessQuestionFrequencyType> builder)
        {
            builder.Property(property => property.Description).IsRequired();

            builder.HasData(
                new WellnessQuestionFrequencyType() 
                { 
                    Id = 1, 
                    Description="Daily"
                },
                new WellnessQuestionFrequencyType()
                {
                    Id = 2,
                    Description = "Weekly"
                }
            );
                
        }
    }
}
