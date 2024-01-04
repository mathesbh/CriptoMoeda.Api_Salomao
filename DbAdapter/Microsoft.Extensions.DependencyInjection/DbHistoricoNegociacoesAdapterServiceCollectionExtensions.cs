using DbAdapter;
using Domain.Adapters;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.DependencyInjection.MercadoBitcoinAdapter
{
    public static class DbHistoricoNegociacoesAdapterServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddDbHistoricoNegociacoesAdapter(
            this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<IDbHistoricoNegociacoesAdapter, DbHistoricoNegociacoesAdapter>();

            return services;
        }
    }
}
