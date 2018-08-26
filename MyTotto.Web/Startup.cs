using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyTotto.Data;
using MyTotto.Data.Abstract;
using MyTotto.Data.Repositories;
using MyTotto.Web.AppStart;

namespace MyTotto
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
            contentRootPath = environment.ContentRootPath;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        private readonly string contentRootPath;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            if (connection.Contains("%CONTENTROOTPATH%"))
            {
                connection = connection.Replace("%CONTENTROOTPATH%", contentRootPath);
            }

            services.AddRepositories(Configuration);
            services.AddAndConfigureSwagger();

            services.AddMvc()
                .AddApplicationPart(Assembly.Load("MyTotto.Api"))
                .AddControllersAsServices();

            services.AddDbContext<TottoContext>(options => 
                options.UseSqlServer(connection, optBuilder => 
                    optBuilder.MigrationsAssembly("MyTotto.Web")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            //// Set up data directory
            //string appRoot = env.ContentRootPath;
            //AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(appRoot, "../", "App_Data"));




            app.UseStaticFiles();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "MyTotto API V1");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
