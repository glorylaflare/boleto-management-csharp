using Microsoft.EntityFrameworkCore;

namespace boleto.Infra.Data.Context;

public class BoletoAppContext : DbContext
{
    // TODO: Adicionar DbSets aqui, por exemplo:
    // public DbSet<YourEntity> YourEntities { get; set; }

    public BoletoAppContext(DbContextOptions<BoletoAppContext> options) : base(options) { }
}
