using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DbAdapter
{
    public class CriptomoedaDbContext
    {
        public DbSet<HistoricoNegociacoes> HistoricoNegociacoes { get; set; }
        public DbSet<HistoricoNegociacao> HistoricoNegociacao { get; set; }
    }
}