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
            string connection = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<TottoContext>(options => options.UseSqlServer(connection));

            services.AddScoped<IBannersRepository, BannersRepository>();

            return services;
        }
    }
}
