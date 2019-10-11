using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;
using CSharp_CheatSheet.Helpers;
using CSharp_CheatSheet.Model;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CSharp_CheatSheet
{
    public class Startup
    {
        // dependency injection =  allow us to create system that are loosely coupled extensible and easily testable
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // configure the services required for application
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.Configure<CookiePolicyOptions>(options =>
        //    {
        //        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        //        options.CheckConsentNeeded = context => true;
        //        options.MinimumSameSitePolicy = SameSiteMode.None;
        //    });


        //    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        //}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<myWebAppContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("myWebAppContext")));

            var _video = new VideoAPI();
            _video.Initialize();    //to call API just for once

            //HealthCheck
            services.AddHealthChecksUI();           //register health check

            services.AddHealthChecks()
                .AddSqlServer(Configuration["Data:ConnectionStrings:Sql"])
                .AddRedis(Configuration["Data:ConnectionStrings:Redis"]);

            services.AddHealthChecks()
                .AddSqlServer(
            connectionString: Configuration["Data:ConnectionStrings:Sql"],
            healthQuery: "SELECT 1;",
            name: "sql",
            failureStatus: HealthStatus.Degraded,
            tags: new string[] { "db", "sql", "sqlserver" });

         

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. (each of the function which use IApplicationBuilder(app) is called MIDDLEWARE)
        // Configure application, request, processing, pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }


            app.UseStaticFiles();

            /*
                // to use other static file name as default instead of using default.html
                DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();       
                defaultFilesOptions.DefaultFileNames.Clear();
                defaultFilesOptions.DefaultFileNames.Add("foo.html");
                app.UseDefaultFiles(defaultFilesOptions);
            */

            /* 
                // to use that static files as default
                app.UseDefaultFiles(); 
            */


            app.UseStaticFiles();   //use static file (wwwroot file)
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });



            app.UseHealthChecksUI(o =>
            {
                o.UIPath = "/health-ui";
            });



            //app.UseRouting()
            // .UseEndpoints(config =>
            // {
            //     config.MapHealthChecks("/healthz", new HealthCheckOptions
            //     {
            //         Predicate = _ => true,
            //         ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            //     });
            // });



        }
    }
}
