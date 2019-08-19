using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using P111_CodeAcademy.DAL;

namespace P111_CodeAcademy
{
    public class Startup
    {
        private IConfiguration _config;
         
        public Startup(IConfiguration configuration)
        { 
            _config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);//incapsule olunmus version
                // options.UseSqlServer(_config"Server=DESKTOP-VG62E1O; Initial catalog=FirstDb; Security integrated = sspi");
            });
            //Bizim AppDbContext clasinda
            //public class AppDbContext : DbContext
            // DbContext deyirki mene parametrleri gonder 
            //sene database statusunu verim.options eslinde 
            //stringconnection-dir. Cunki Bizim DbContext 
            //hanci stringconnectionla baglandigini bilmelidir.


            // services LifeTime
            //services.AddSingleton;
            //services.AddScoped;
            //services.AddTransient; 
        }
        //AppDbContext Database-in qarsiligi olraq DataBase class-dir

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //Adi Properties"ASPNETCORE_ENVIRONMENT": "Development yox basqa ad qoyursan onda error seh cixir"
            }
            else
            {
                app.UseExceptionHandler("/home/error");
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller=home}/{action=index}/{id?}"
            );
            });
        }
    }
}
