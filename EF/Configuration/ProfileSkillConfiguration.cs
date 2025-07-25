using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ProfileSkillConfiguration : IEntityTypeConfiguration<ProfileSkill>
    {
        public void Configure(EntityTypeBuilder<ProfileSkill> builder)
        {
            builder.Property(property => property.ProfileId).IsRequired();
            builder.Property(property => property.SkillName).IsRequired();
            builder.Property(property => property.ProficiencyLevelId).IsRequired();

            builder
                .HasOne(e => e.Profile)
                .WithMany(e => e.ProfileSkills)
                .HasForeignKey(e => e.ProfileId)
                .IsRequired();
        }
    }
}
