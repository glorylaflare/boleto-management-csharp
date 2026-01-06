using boleto.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace boleto.Infra.Data.Mappings;

public class BankSlipPaymentMap : IEntityTypeConfiguration<BankSlipPaymentBatchEntity>
{
    public void Configure(EntityTypeBuilder<BankSlipPaymentBatchEntity> builder)
    {
        builder.ToTable("BankSlipPaymentBatches");

        builder.HasKey(bs => bs.Id);
        builder.Property(bs => bs.CreatedAt);
        builder.Property(bs => bs.UpdatedAt);

        builder.Property(bs => bs.RequesterId);
        builder.Property(bs => bs.Status);

        builder.OwnsMany(bs => bs.PaymentTitles, pt =>
        {
            pt.ToTable("PaymentTitles");
            pt.Property(p => p.PaymentId);
            pt.Property(p => p.PaymentCode);
            pt.Property(p => p.Amount);
        });

    }
}
