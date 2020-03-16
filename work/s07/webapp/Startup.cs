using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using webapp.Models;
using webapp.Services;
using webapp.Pages;
using webapp.Controllers;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Web;


namespace webapp
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
            services.AddRazorPages();
            services.AddTransient<JsonFileAccountService>();
            services.AddControllers();
            // services.ViewControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                 endpoints.MapRazorPages();


            //         endpoints.MapGet("/accounts", (context) => {
            //         var accounts = 
            //         app.ApplicationServices.GetService<JsonFileAccountService>()
            //         .GetAccounts();
            //         var json = JsonSerializer.Serialize<IEnumerable<Account>>(accounts);
            //         return context.Reponse.WriteAsync(json);
            // });

            endpoints.MapControllers();

            });
        }
    } 
}
