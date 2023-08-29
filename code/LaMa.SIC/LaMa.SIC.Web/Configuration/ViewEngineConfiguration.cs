using LaMa.SIC.Core.Routing;
using Microsoft.Extensions.FileProviders;

namespace LaMa.SIC.Web.Configuration
{
    public static class ViewEngineConfiguration
    {
        public static void ConfigureSICViews(this IServiceCollection services)
        {
            var assembly = typeof(IRouteProvider).Assembly;
            services.AddControllersWithViews().AddApplicationPart(assembly);
        }
    }
}