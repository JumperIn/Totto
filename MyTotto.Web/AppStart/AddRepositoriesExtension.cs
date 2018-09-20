using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Repositories;

namespace MyTotto.Web.AppStart
{
    internal static class AddRepositoriesExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IBannersRepository, BannersRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();

            return services;
        }
    }
}
