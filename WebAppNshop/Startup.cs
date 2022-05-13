using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nshopsolution.Data.EF;
using Microsoft.EntityFrameworkCore.InMemory;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WebAppNshop
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
            services.AddDbContext<EShopDbContext>(option => option.UseInMemoryDatabase("InMemoryDB")) ;
            //services register and login
            services.AddIdentity<AppUser, AppRole>(
                options =>
                {
                    options.User.RequireUniqueEmail = false;
                    options.SignIn.RequireConfirmedAccount = false;

                }).AddEntityFrameworkStores<EShopDbContext>().AddDefaultTokenProviders();
            string connectionString = Configuration.GetConnectionString("ConnectionString");
            services.AddDbContext<EShopDbContext>(c => c.UseSqlServer(connectionString));
            services.AddControllersWithViews();
            //enable dbcontext
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.Name = "InMemoryDB";
                option.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                option.LoginPath = "/Accounts/SignIn";
            });
            //add session
            services.AddSession();
            
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
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
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
