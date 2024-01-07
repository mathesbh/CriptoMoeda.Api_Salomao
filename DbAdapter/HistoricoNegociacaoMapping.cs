using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace DbAdapter
{
    public class HistoricoNegociacaoMapping : IEntityTypeConfiguration<HistoricoNegociacao>
    {
        public void Configure(EntityTypeBuilder<HistoricoNegociacao> builder)
        {
            builder.HasKey(e => e.SiglaMoeda);
        }
    }
}
