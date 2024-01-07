using DbAdapter;
using Domain.Adapters;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.DependencyInjection.MercadoBitcoinAdapter
{
    public static class DbHistoricoNegociacoesAdapterServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddDbHistoricoNegociacoesAdapter(
            this IServiceCollection services, string connection)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddDbContext<CriptomoedaDbContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            services.AddScoped<IDbHistoricoNegociacoesAdapter, DbHistoricoNegociacoesAdapter>();

            return services;
        }
    }
}
