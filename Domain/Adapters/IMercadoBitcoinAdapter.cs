using Domain.Models;

namespace Domain.Adapters
{
    public interface IMercadoBitcoinAdapter
    {
        /// <summary>
        ///     Dados das �ltimas 24 horas de negocia��es de uma criptomoeda especifica.
        /// </summary>
        /// <param name="siglaMoeda">Sigla da criptomoeda que deseja obter dados.</param>
        /// <returns>
        ///     Informa��es com o resumo das �ltimas 24 horas de negocia��es.
        /// </returns>
        Task<NegociacoesDoDia> ObterDadosNegociacoesDoDiaAsync(string siglaMoeda);
    }
}
