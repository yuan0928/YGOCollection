using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YGOCollection.DTO;
using YGOCollection.Repository;
using YGOCollection.Repository.DataModels;
using YGOCollection.Repository.Interface;
using YGOCollection.Service;
using YGOCollection.Service.Interface;

namespace YGOCollection
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
            services.AddControllersWithViews();
            services.AddDbContext<YGOContext>(options => options.UseSqlServer(Configuration.GetConnectionString("YGOConnection")));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IGenericService<CardSeriesDTO>, CardSeriesService>();
            services.AddScoped<IGenericService<CardInfoDTO>, CardInfoService>();
            services.AddScoped<IGenericService<CardTypeDTO>, CardTypeService>();
            services.AddScoped<IGenericRepository<CardInfo>, GenericRepository<CardInfo>>();
            services.AddScoped<IGenericRepository<CardSeries>, GenericRepository<CardSeries>>();
            services.AddScoped<IGenericRepository<CardType>, GenericRepository<CardType>>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
