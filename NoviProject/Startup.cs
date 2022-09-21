using Microsoft.Extensions.Configuration;
using NoviProject.Services;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Web.Administration;
using ConfigurationSection = Microsoft.Web.Administration.ConfigurationSection;

namespace NoviProject
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllersWithViews();
            services.AddSingleton<INoviAMSApiService, NoviAMSApiService>();
            services.AddHttpClient("NoviAMSApiService", c =>
            {
            c.BaseAddress = new Uri("https://180930b.novitesting.com/");
            c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "oNiPIWDjyGSkvLuxwHTzbXgBg2woNoW2TjU/tJs0E7U=");
                });
            services.AddRazorPages();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{searchString?}");
            app.MapRazorPages();
            app.Run();

        }
    }
}
