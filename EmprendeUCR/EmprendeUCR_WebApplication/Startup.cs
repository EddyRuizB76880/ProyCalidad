using EmprendeUCR_WebApplication.Data;
using EmprendeUCR_WebApplication.Data.Contexts;
using EmprendeUCR_WebApplication.Data.Entities;
using EmprendeUCR_WebApplication.Data.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Services.Categories;
using Syncfusion.Blazor;

namespace EmprendeUCR_WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SqlServerDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddIdentity<UserService, IdentityRole>().AddEntityFrameworkStores<BookStoreContext>().AddDefaultTokenProviders();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSyncfusionBlazor();
            services.AddScoped<CategoryService>();
            services.AddScoped<AddCategoryService>();
            services.AddScoped<DeleteCategoryService>();
            services.AddScoped<EditCategoryService>();
            services.AddScoped<ProductService>();
            services.AddScoped<EntrepreneurService>();
            services.AddScoped<UserService>();
            services.AddScoped<Product_ServiceService>();
            services.AddScoped<ProvinceService>();
            services.AddScoped<CantonService>();
            services.AddScoped<DistrictService>();
            services.AddScoped <CredentialsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDQ4ODMyQDMxMzkyZTMxMmUzMGo0R1FZZUUxWjE5WEFUd01hWXVlbllPTFllcG50R0UvTEhNbS9ocGVJWlU9"); // TODO: move to another file
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
