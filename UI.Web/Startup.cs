using AspNetCoreHero.ToastNotification;
using AutoMapper;
using Business.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;
using System;

namespace UI.Web
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
            services.AddAutoMapper(typeof(Startup));

            services.AddControllersWithViews();
            services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.TopRight; });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Login";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.AccessDeniedPath = "/Home/Privacy";


            });

            services.AddAuthorization(options =>
            {
                using var context = new AcademiaContext();
                foreach (var item in context.Modulos)
                {
                    options.AddPolicy($"{item.Ejecuta}.Alta", policy =>
                       policy.RequireClaim("Modulo", $"{item.Ejecuta}.Alta"));

                    options.AddPolicy($"{item.Ejecuta}.Modificacion", policy =>
                   policy.RequireClaim("Modulo", $"{item.Ejecuta}.Modificacion"));

                    options.AddPolicy($"{item.Ejecuta}.Baja", policy =>
                        policy.RequireClaim("Modulo", $"{item.Ejecuta}.Baja"));

                    options.AddPolicy($"{item.Ejecuta}.Consulta", policy =>
                       policy.RequireClaim("Modulo", $"{item.Ejecuta}.Consulta"));
                }
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime)
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
            app.UseFastReport();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });

            applicationLifetime.ApplicationStopping.Register(OnShutdown);
        }

        private void OnShutdown()
        {
            // Libera aquí los recursos, como la conexión de `AcademiaContext`
            Adapter.dbContext.Dispose();
        }
    }


}
