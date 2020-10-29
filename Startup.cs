using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MVCApp.Controllers;
using MVCApp.Models;

namespace MVCApp
{
    public class Startup
    {

        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
           
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("ConexionSQL")));
            // Para agregar este tipo de arquitectura
            services.AddMvc();
            // Crea un servicio Singleton cuando se solicita por primera vez. Una vez que se instancia una vez no se vuelve a instanciar
            //services.AddSingleton<IAmigoAlmacen, MockAmigoRepositorio>();
            services.AddScoped<IAmigoAlmacen, SQLAmigoRepsitorio>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Para poder usar ficheros estaticos, deben ir en este orden
            app.UseStaticFiles();
            // Nos servirá lo que haya en la clase controlador

            app.UseMvcWithDefaultRoute();
            
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
