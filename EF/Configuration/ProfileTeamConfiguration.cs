using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileTeamConfiguration : IEntityTypeConfiguration<ProfileTeam>
    {
        public void Configure(EntityTypeBuilder<ProfileTeam> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.TeamName).IsRequired();
            builder.Property(property => property.Position).IsRequired();
            builder.Property(property => property.StartDate).IsRequired();
            builder.Property(property => property.EndDate).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileTeams)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
