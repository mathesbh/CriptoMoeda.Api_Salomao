using AutoMapper;
using Domain.Adapters;
using Domain.Models;

namespace DbAdapter
{
    internal class DbHistoricoNegociacoesAdapter : IDbHistoricoNegociacoesAdapter
    {
        private readonly IMapper mapper;
        private readonly CriptomoedaDbContext context;

        public DbHistoricoNegociacoesAdapter(IMapper mapper, CriptomoedaDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task SalvarHistoricoNegociacoesAsync(NegociacoesDoDia dadosNegociacoes, string siglaMoeda)
        {
            try
            {
                var historicoNegociacoes = mapper.Map<HistoricoNegociacoes>(dadosNegociacoes);
                historicoNegociacoes.AdicionarSiglaMoeda(siglaMoeda);
                
                context.HistoricoNegociacoes.Add(historicoNegociacoes);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
