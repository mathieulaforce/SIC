using LaMa.SIC.Core.Controllers;
using Microsoft.AspNetCore.Mvc.Razor;

namespace LaMa.SIC.Core.Configuration
{
    public static class SICConfiguration
    {
        public static void ConfigureSIC(this IServiceCollection services)
        {
            var assembly = typeof(SICController).Assembly;
            services.AddControllersWithViews().AddApplicationPart(assembly);
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new FeatureLocationExpander());
            });
        }
    }
}
