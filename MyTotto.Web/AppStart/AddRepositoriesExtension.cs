using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using MyTotto.Data.Abstract;
using MyTotto.Data.Repositories;

namespace MyTotto.Web.AppStart
{
    public static class AddRepositoriesExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICommonRepository, CommonRepository>();


            return services;
        }
    }
}
