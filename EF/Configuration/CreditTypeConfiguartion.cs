using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using play_360.EF.Models;

namespace play_360.EF.Configuration
{
    public class CreditTypeConfiguartion : IEntityTypeConfiguration<CreditType>
    {
        public void Configure(EntityTypeBuilder<CreditType> builder)
        {
            builder.Property(property => property.Id).IsRequired();
            builder.Property(property => property.Description).IsRequired();

            builder
                .HasMany(creditType => creditType.Credits)
                .WithOne(credit => credit.CreditType)
                .HasForeignKey(credit => credit.CreditTypeId)
                .IsRequired();

            builder.HasData(
                new CreditType() 
                { 
                    Id = 1, 
                    Description="Earned"
                },
                 new CreditType()
                 {
                     Id = 2,
                     Description = "Purchased"
                 }
            );

        }
    }
}
