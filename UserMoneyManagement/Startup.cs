using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
//using UserMoneyManagement.Interfaces;
using UserMoneyManagement.Models;
//using ASPNetCoreIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace UserMoneyManagement
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
            services.AddRazorPages();
            // Add ApplicationDbContext to DI
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
           
            // AddIdentity adds cookie based authentication
            // Adds scoped classes for things like UserManager, SignInManager, PasswordHashers etc..
            // NOTE: Automatically adds the validated user from a cookie to the HttpContext.User
            // https://github.com/aspnet/Identity/blob/85f8a49aef68bf9763cd9854ce1dd4a26a7c5d3c/src/Identity/IdentityServiceCollectionExtensions.cs
            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.User.RequireUniqueEmail = true)
            // Adds UserStore and RoleStore from this context
            // That are consumed by the UserManager and RoleManager
            // https://github.com/aspnet/Identity/blob/dev/src/EF/IdentityEntityFrameworkBuilderExtensions.cs 
                .AddEntityFrameworkStores<ApplicationDbContext>()
            // Adds a provider that generates unique keys and hashes for things like
            // forgot password links, phone number verification codes etc...
                .AddDefaultTokenProviders();
            
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            
            // Setup Identity
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
