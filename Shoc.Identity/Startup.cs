using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shoc.ApiCore;
using Shoc.ApiCore.DataProtection;
using Shoc.Identity.Config;
using Shoc.Identity.OpenId;
using Shoc.Identity.Services;

namespace Shoc.Identity
{
    /// <summary>
    /// The startup application
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The configuration
        /// </summary>
        private IConfiguration Configuration { get; }

        /// <summary>
        /// Creates new instance of startup
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Configure services
        /// </summary>
        /// <param name="services">The services to configure</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSelf(this.Configuration);
            services.AddPersistenceDataProtection();
            services.AddAuthenticationEssentials(this.Configuration);
            services.AddIdentityEssentials(this.Configuration);
            services.AddLocalApiProtection();
            services.AddMailing(this.Configuration);
            services.AddRepositories(this.Configuration);

            services.AddControllersWithViews();
            services.AddControllers();
            services.AddAnyOriginCors(ApiDefaults.DEFAULT_CORS);
            services.AddForwardingConfiguration();

            // in production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            // add same-site cookie policy
            services.AddSameSiteCookiePolicy();

            services.AddSingleton<UserService>();
            services.AddScoped<AuthService>();
        }

        /// <summary>
        /// Configure the HTTP request pipeline
        /// </summary>
        /// <param name="app">The app</param>
        /// <param name="env">The environment</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseForwardedHeaders();
            }
            else
            {
                app.UseExceptionHandler("/error");
                app.UseForwardedHeaders();
                app.UseHsts();
            }

            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default", "{controller}/{action=Index}/{id?}"));
            app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto });
            app.UseMiddleware<PublicOriginMiddleware>();
            app.UseCors(ApiDefaults.DEFAULT_CORS);
            app.UseIdentityServer();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer("start");
                }
            });
        }
    }
}
