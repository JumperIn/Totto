using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

namespace MyTotto.Web.AppStart
{
    /// <summary>
    /// Расширение для добавления средства документирования Swagger Codegen.
    /// </summary>
    public static class AddSwaggerExtension
    {
        /// <summary>
        /// Активация и настройка средства документирования API: Swagger Codegen.
        /// </summary>
        public static IServiceCollection AddAndConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                string basePath = PlatformServices.Default.Application.ApplicationBasePath;

                // Для отображение даты последнего обновления
                // использую дату последнего изменения файла документации
                DateTime dateTimeUpdate = File.GetLastWriteTime(basePath + "MyTotto.Web.xml");

                options.SwaggerDoc("v1", new Info
                {
                    Title = "MyTotto Web API",
                    Version = "v1",
                    Description = $"MyTotto [ASP.NET Core Web API]. Last update: { dateTimeUpdate }"
                });

                // Set the comments path for the swagger json and ui.
                options.IncludeXmlComments(Path.Combine(basePath, "MyTotto.Web.xml"));
                options.IncludeXmlComments(Path.Combine(basePath, "MyTotto.Api.xml"));
                options.IncludeXmlComments(Path.Combine(basePath, "MyTotto.Data.xml"));
            });

            return services;
        }
    }
}
