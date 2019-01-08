using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MyTotto.BusinessLogic.Abstract;
using MyTotto.BusinessLogic.Services;

namespace MyTotto.Web.AppStart
{
    internal static class AddServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductsFilterService, ProductsFilterService>();

            return services;
        }
    }
}
