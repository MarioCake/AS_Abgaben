using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookiClickerEF.Context;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.EntityFrameworkCore.Firebird.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projekt.Services;

namespace Projekt
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CookieClickerContext>(options =>
            {
                string clientLibrary = System.IO.Path.Combine(Environment.CurrentDirectory, "fbclient.dll");
                FbConnectionStringBuilder builder = new FbConnectionStringBuilder
                {
                    Database = "CookieClicker.fdb",
                    ClientLibrary = clientLibrary,
                    UserID = "sysdba",
                    Password = "masterkey",
                    ServerType = FbServerType.Embedded,
                    Charset = "UTF8"
                };

                FbConnection connection = new FbConnection(builder.ConnectionString);

                options.UseFirebird(connection);
            });

            services.AddScoped<GameStateValidation>();

            services.AddMvc();
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

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
