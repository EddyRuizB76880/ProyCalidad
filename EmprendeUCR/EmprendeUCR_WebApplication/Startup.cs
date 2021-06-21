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
using Blazored.SessionStorage;

using EmprendeUCR_WebApplication.Application.ShoppingCartContext;
using EmprendeUCR_WebApplication.Infrastructure.Core;

using EmprendeUCR_WebApplication.Domain.Repositories;

using EmprendeUCR_WebApplication.Application.ShoppingCartContext.Implementations;
using EmprendeUCR_WebApplication.Infrastructure.ShoppingCartContext;

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
            services.AddDbContext<ShoppingCartDbContext2>(options =>
            {
                options.UseSqlServer((Configuration.GetConnectionString("DefaultConnection")));

            });
              
            services.AddDbContext<SqlServerDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });


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
            services.AddScoped<CredentialsService>();
            services.AddScoped<LikesService>();
            services.AddScoped<ClientService>();
            services.AddScoped<MembersService>();
            services.AddScoped<RegisterService>();
            services.AddScoped<MailService>();
            services.AddScoped<Email_ConfirmationService>();
            services.AddScoped<AdministratorService>();
            services.AddScoped<EncrypService>();
            services.AddScoped<LoginService>();
            services.AddBlazoredSessionStorage();

            Global.ConnectionString = Configuration.GetConnectionString("SqlConnection");
            Global.DomainName = Configuration["DomainName"];
            services.AddScoped <CredentialsService>();
            services.AddScoped<OfferService>();
            services.AddScoped<Is_OfferService>();
            services.AddScoped<ServiceService>();
            services.AddScoped<Product_PhotosService>();
            services.AddScoped<Service_PhotosService>();
            //services.AddScoped<ServiceService>();


            services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

            services.AddTransient<IShoppingCartService, ShoppingCartService>();

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
