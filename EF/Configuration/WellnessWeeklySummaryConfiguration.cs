using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class WellnessWeeklySummaryConfiguration : IEntityTypeConfiguration<WellnessWeeklySummary>
    {
        public void Configure(EntityTypeBuilder<WellnessWeeklySummary> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.WeekStart).IsRequired();
            builder.Property(property => property.AverageFeeling).IsRequired();
            builder.Property(property => property.InjuryCount).IsRequired();
            builder.Property(property => property.SummaryNote).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.WellnessWeeklySummaries)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
