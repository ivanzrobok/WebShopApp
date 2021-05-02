using FirstWebapplication.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebapplication.Data;
using FirstWebapplication.Data.Repository;
using Microsoft.EntityFrameworkCore.Design;
using FirstWebapplication.Data.Models;


namespace FirstWebapplication
{
    
    public class Startup
    {
        private IConfigurationRoot _confString;
        
        public Startup(IWebHostEnvironment webHost)
        {
            _confString = new ConfigurationBuilder()
                .SetBasePath(webHost.ContentRootPath)
                .AddJsonFile("dbsettings.json").Build();

        }     
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {             //перехідний 
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars, CarReposetory>();
            services.AddTransient<ICarsCategory, CategoryReposetory>();
            services.AddTransient<IAllOrders, OrdersRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCar(sp));//для сесій
            

            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();

            //опис адреса та сторінки яка буде відкриватися за замовчуванням
            app.UseMvc(routes => {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Car/{action}/{category?}", defaults: new { Controller = "Cars", action = "List" });
            });

            AppDBContent content;
            using (var score = app.ApplicationServices.CreateScope())
            {
                content = score.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObject.Initial(content);
            }
            //AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();

        }

    }

    
}
