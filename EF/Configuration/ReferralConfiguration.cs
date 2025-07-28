using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class ReferralConfiguration : IEntityTypeConfiguration<Referral>
    {
        public void Configure(EntityTypeBuilder<Referral> builder)
        {
            builder.Property(property => property.ReffererUserId).IsRequired();
            builder.Property(property => property.RefferedUserId).IsRequired();
            builder.Property(property => property.ReferralStatusId).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.Referrals)
                .HasForeignKey(e => e.ReffererUserId)
                .IsRequired();
        }
    }
}
