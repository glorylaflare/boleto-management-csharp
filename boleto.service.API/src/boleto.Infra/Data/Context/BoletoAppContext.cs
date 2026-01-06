using boleto.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace boleto.Infra.Data.Context;

public class BoletoAppContext : DbContext
{
    public BoletoAppContext(DbContextOptions<BoletoAppContext> options) : base(options) { }

    public DbSet<BankSlipPaymentBatchEntity> BankSlipPaymentBatches { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) => 
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BoletoAppContext).Assembly);
}
