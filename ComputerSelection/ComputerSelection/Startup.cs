using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerSelection.Data;
using ComputerSelection.Service;
using ComputerSelection.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace ComputerSelection
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
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(2);
            });
            services.AddMvc();
            services.AddRazorPages();
            services.AddDbContext<ApplicationContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("ComputerSelectionContext")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICPUService, CPUService>();
            services.AddTransient<IGPUService, GPUService>();
            services.AddTransient<IRAMService, RAMService>();
            services.AddTransient<ISSDService, SSDService>();
            services.AddTransient<IHARDDISKService, HARDDISKService>();
            services.AddTransient<IMAINBOARDService, MAINBOARDService>();
            services.AddTransient<ILogService, LOGService>();
            services.AddTransient<IComputerService, ComputerService>();
            services.AddTransient<ISystemRequirementService, SystemRequirementService>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
                { x.LoginPath = "/Home/Login/"; }
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();
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
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=UserL}/{id?}");
            });
        }
    }
}
