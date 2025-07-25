using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(property => property.UserId).IsRequired();
            builder.Property(property => property.Amount).IsRequired();
            builder.Property(property => property.CreatedAt).IsRequired();

            builder
             .HasOne(e => e.User)
             .WithMany(e => e.Transactions)
             .HasForeignKey(e => e.UserId)
             .IsRequired();

            builder
              .HasOne(e => e.Credit)
              .WithOne(e => e.Transaction)
              .HasForeignKey<Transaction>(e => e.CreditId)
              .OnDelete(DeleteBehavior.NoAction)
              .IsRequired();
        }
    }
}
