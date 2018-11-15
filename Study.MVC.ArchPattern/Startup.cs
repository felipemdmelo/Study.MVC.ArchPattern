using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Study.MVC.ArchPattern.Application.Commercial.Implementations;
using Study.MVC.ArchPattern.Application.Commercial.Interfaces;
using Study.MVC.ArchPattern.Domain.Repositories.Interfaces;
using Study.MVC.ArchPattern.Domain.Services.Implementations;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;
using Study.MVC.ArchPattern.Infra.Data.Local.Repositories.Implementations;

namespace Study.MVC.ArchPattern
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            #region DEPENDENCY INJECTION DECLARATIONS..
            
            #region APPLICATION..
            services.AddTransient<IAddProductWithStock, AddProductWithStock>();
            services.AddTransient<IGetProduct, GetProduct>();
            #endregion

            #region DOMAIN..
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IStockService, StockService>();
            #endregion

            #region INFRA DATA..
            services.AddTransient<IProductRepository, LocalProductRepository>();
            services.AddTransient<IStockRepository, LocalStockRepository>();
            #endregion

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
