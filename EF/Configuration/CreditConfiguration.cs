using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class CreditConfiguration : IEntityTypeConfiguration<Credit>
    {
        public void Configure(EntityTypeBuilder<Credit> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.CreditTypeId).IsRequired();
            builder.Property(property => property.Amount).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
                .HasOne(e => e.User)
                .WithMany(e => e.Credits)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            builder
               .HasOne(e => e.Transaction)
               .WithOne(e => e.Credit)
               .HasForeignKey<Transaction>(e => e.CreditId)
               .OnDelete(DeleteBehavior.NoAction)
               .IsRequired();

        }
    }
}