using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RoutingDemo.Models;

namespace RoutingDemo
{
    public class Startup
    {
        private readonly IConfiguration config;
        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            var conn = config.GetConnectionString("VehiclesConnectionString");

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(conn));

            services.AddTransient<IVehicleRepository, VehicleRepository>();

            services.AddMvc().AddXmlDataContractSerializerFormatters().AddMvcOptions(options =>
            {
                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", "application/xml");
                //options.RespectBrowserAcceptHeader = true;
                //options.ReturnHttpNotAcceptable = true;
            });
            
            services.AddSession();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseStaticFiles();
            app.UseSession();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/error.html");
            }
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=services}/{action=index}"
                    );
            });
        }
    }
}
