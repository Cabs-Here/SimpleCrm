﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleCrm.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IGreeter, ConfigurationGreeter>();
            services.AddScoped<ICustomerData, InMemoryCustomerdata>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
