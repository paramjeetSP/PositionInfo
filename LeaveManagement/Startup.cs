using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagement.Database;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace LeaveManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                    builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                    builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                    builder.WithOrigins("https://localhost:44325").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                    builder.WithOrigins("http://182.76.195.171:5466").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                    builder.WithOrigins("http://182.75.88.147:8888").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                    builder.WithOrigins("http://192.168.0.78:8459").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                    builder.WithOrigins("http://182.76.195.171:8459").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
                });
            });
            services.AddDbContext<Recovered_hrmsnewContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DBConnection")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie((options =>
            {
                options.LoginPath = "/Account/Login/";
                options.AccessDeniedPath = "/Account/AccessDenied";

            }));
            services.AddSingleton<Microsoft.AspNetCore.Http.IHttpContextAccessor, Microsoft.AspNetCore.Http.HttpContextAccessor>();

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "LMS",
                    Description = "Leave Management Service Api's",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Login page",
                        Email = string.Empty,
                        Url = "http://192.168.0.78:8459/#/Appraisal/Login",
                    }                    
                });
            });
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
            }
            app.UseCors(MyAllowSpecificOrigins);
            app.UseStaticFiles();
         //   app.UseCookiePolicy();
            app.UseAuthentication();
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/Account/PageNotFound";
                    await next();
                }
            });
            app.UseSession();
            //  app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    //template: "{controller=Dashboard}/{action=Index}/{id?}");
                    template: "{controller=Account}/{action=Login}/{id?}");
                routes.MapRoute(name: "api", template: "api/{controller=DashboardApi}");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Leave Management Service Api V1");
            });
        }
    }
}
