using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MyTotto.Data;

namespace MyTotto.Web.AppStart
{
    public static class AddContextExtension
    {
        public static IServiceCollection AddContext(this IServiceCollection services)
        {
            string defaultConnection = "Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;";
            services.AddDbContext<TottoContext>(options => options.UseSqlServer(defaultConnection));
            
            return services;
        }
    }
}
