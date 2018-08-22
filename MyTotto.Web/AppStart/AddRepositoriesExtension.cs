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
            string databaseConnection = configuration.GetSection("AppSettings").GetValue<string>("DatabaseConnection");

            //services.AddDbContext<TottoContext>(options => options.UseSqlServer(databaseConnection));

            //services.AddScoped<ICommonRepository>(provider => new CommonRepository(databaseConnection));
            services.AddScoped<IBannersRepository>(provider => new BannersRepository(databaseConnection));

            return services;
        }
    }
}
