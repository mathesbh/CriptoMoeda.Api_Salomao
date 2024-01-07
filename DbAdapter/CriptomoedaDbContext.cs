using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DbAdapter
{
    public class CriptomoedaDbContext : DbContext
    {
        public CriptomoedaDbContext(DbContextOptions<CriptomoedaDbContext> options) : base(options) { } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CriptomoedaDbContext).Assembly);
        }

        public DbSet<HistoricoNegociacoes> HistoricoNegociacoes { get; set; }
        public DbSet<HistoricoNegociacao> HistoricoNegociacao { get; set; }
    }
}