using Domain.Adapters;
using Domain.Models;
using Domain.Services;

namespace Application
{
    public class CriptoMoedaService : ICriptoMoedaService
    {
        private readonly IMercadoBitcoinAdapter mercadoBitcoinAdapter;
        private readonly IDbHistoricoNegociacoesAdapter dbHistoricoNegociacoesAdapter;
        public CriptoMoedaService(IMercadoBitcoinAdapter mercadoBitcoinAdapter, IDbHistoricoNegociacoesAdapter dbHistoricoNegociacoesAdapter)
        {
            this.mercadoBitcoinAdapter = mercadoBitcoinAdapter ??
                throw new ArgumentNullException(nameof(mercadoBitcoinAdapter));
            this.dbHistoricoNegociacoesAdapter = dbHistoricoNegociacoesAdapter ??
                throw new ArgumentNullException(nameof(dbHistoricoNegociacoesAdapter));
        }
        public async Task<NegociacoesDoDia> ObterDadosNegociacoesDoDiaAsync(string siglaMoeda)
        {
            ValidaSiglaMoeda(siglaMoeda);

            return await mercadoBitcoinAdapter.ObterDadosNegociacoesDoDiaAsync(siglaMoeda);
        }

        public async Task<NegociacoesDoDia> ObterDadosNegociacoesDoDiaComHistoricoAsync(string siglaMoeda)
        {
            ValidaSiglaMoeda(siglaMoeda);

            var dadosNegociacoes = await mercadoBitcoinAdapter.ObterDadosNegociacoesDoDiaAsync(siglaMoeda);

            await dbHistoricoNegociacoesAdapter.SalvarHistoricoNegociacoesAsync(dadosNegociacoes, siglaMoeda);

            return dadosNegociacoes;
        }

        private void ValidaSiglaMoeda(string siglaMoeda) 
        {
            if (string.IsNullOrWhiteSpace(siglaMoeda))
            {
                throw new ArgumentException("Sigla escolhida não é valida.");
            }
        }
    }
}