using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace DbAdapter
{
    public class HistoricoNegociacoesMapping : IEntityTypeConfiguration<HistoricoNegociacoes>
    {
        public void Configure(EntityTypeBuilder<HistoricoNegociacoes> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
