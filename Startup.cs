using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;

namespace attendanceSystemAPI
{
    public class Startup
    {
        public Startup(Microsoft.AspNetCore.Hosting.IWebHostEnvironment env, IConfiguration configuration)
        {
            //Configuration = configuration;
            var _env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            if (null == _env)
            {
                Environment.Exit(1);
            }
            else
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(env.ContentRootPath)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{_env}.json", optional: true)
                    .AddEnvironmentVariables();
                Configuration = builder.Build();
            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            AppSetting evnconfig = null;
            try
            {
                evnconfig = new AppSetting(Configuration);
            }
            catch (Exception)
            {
                Environment.Exit(1);
            }
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
