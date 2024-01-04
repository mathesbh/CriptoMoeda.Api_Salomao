using AutoMapper;
using Domain.Adapters;
using Domain.Models;

namespace DbAdapter
{
    internal class DbHistoricoNegociacoesAdapter : IDbHistoricoNegociacoesAdapter
    {
        private readonly IMapper mapper;

        public DbHistoricoNegociacoesAdapter(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task SalvarHistoricoNegociacoesAsync(NegociacoesDoDia dadosNegociacoes, string siglaMoeda)
        {
            try
            {
                var historicoNegociacoes = mapper.Map<HistoricoNegociacoes>(dadosNegociacoes);
                historicoNegociacoes.AdicionarSiglaMoeda(siglaMoeda);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
