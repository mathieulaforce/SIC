using LaMa.SIC.Core.Controllers;

namespace LaMa.SIC.Web.Configuration
{
    public static class ViewEngineConfiguration
    {
        public static void ConfigureSICViews(this IServiceCollection services)
        {
            var assembly = typeof(SICController).Assembly;
            services.AddControllersWithViews().AddApplicationPart(assembly);
        }
    }
}