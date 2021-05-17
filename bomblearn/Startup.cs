using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using layedata;
using datacore;
using Microsoft.AspNetCore.Http;

namespace bomblearn
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
            services.AddDbContext<context>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("bomblearn"));
            }
            );
            services.AddTransient<IAcount, acountback>();
            services.AddTransient<IViewRenderService, RenderViewToString>();
            services.AddTransient<Idoreinter,doreback>();
            services.AddTransient<IVideo, videoback>();
            services.AddTransient<Iuser, userback>();
            services.AddTransient<Iindex, indexback>();
            services.AddTransient<IPaydore, paydoreback>();
            services.AddTransient<Iblog, blogback>();
            services.AddTransient<Isoalinter, soalback>();
            services.AddTransient<Iinteruserpanel, userpanelback>();

            services.AddAuthentication(option=> {
                option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme= CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultSignInScheme= CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(option=> {
                option.LoginPath = "/login";
                option.LogoutPath = "/logout";
                option.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
            });
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
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=indexa}/{id?}");
            });
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode != 404)
                    return;
                context.Request.Path = "/404page.html";
                await next();
            });
            app.Run(async (context) =>
            {
                if (context.Response.StatusCode != 404)
                    return;
                context.Request.Path = "/404page.html";
            });
        }
    }
}
