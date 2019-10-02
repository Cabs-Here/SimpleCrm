using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SimpleCrm.SqlDbServices;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace SimpleCrm.Web
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IGreeter, ConfigurationGreeter>();
            services.AddScoped<ICustomerData, SqlCustomerData>();
            services.AddDbContext<SimpleCrmDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SimpleCrmConnection"))
            );
            services.AddDbContext<CrmIdentityDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SimpleCrmConnection"))
            );
            services.AddIdentity<CrmUser, IdentityRole>()
                .AddEntityFrameworkStores<CrmIdentityDbContext>();

        }

        
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            IGreeter greeter)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(new ExceptionHandlerOptions
                {
                    ExceptionHandler = (context) =>
                    {
                       return context.Response.WriteAsync("Oops!");
                    }
                });
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(ConfigureRoutes);

            app.Run(ctx => ctx.Response.WriteAsync("Not found"));
        }
        private void ConfigureRoutes(IRouteBuilder routes) 
          {
            routes.MapRoute("default",
                "{controller=Home}/{action=Index}/{id?}");
            
           }
    }
}
