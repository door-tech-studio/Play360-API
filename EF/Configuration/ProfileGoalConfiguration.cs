using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileGoalConfiguration : IEntityTypeConfiguration<ProfileGoal>
    {
        public void Configure(EntityTypeBuilder<ProfileGoal> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.Statement).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileGoals)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
