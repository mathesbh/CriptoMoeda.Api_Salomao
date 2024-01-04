using Domain.Models;

namespace Domain.Adapters
{
    public interface IDbHistoricoNegociacoesAdapter
    {
        /// <summary>
        ///     Salva os dados das últimas 24 horas de negociações de uma criptomoeda especifica.
        /// </summary>
        /// <param name="dadosNegociacoes">
        ///     Dados da negociações.
        /// </param>
        /// <param name="siglaMoeda">
        ///     Sigla da criptomoeda que deseja obter dados.
        /// </param>
        Task SalvarHistoricoNegociacoesAsync(NegociacoesDoDia dadosNegociacoes, string siglaMoeda);
    }
}
