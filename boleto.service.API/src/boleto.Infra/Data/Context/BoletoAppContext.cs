using boleto.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace boleto.Infra.Data.Context;

public class BoletoAppContext : DbContext
{
    public DbSet<BankSlipPaymentBatchEntity> BankSlipPaymentBatches { get; set; }

    public BoletoAppContext(DbContextOptions<BoletoAppContext> options) : base(options) { }
}
