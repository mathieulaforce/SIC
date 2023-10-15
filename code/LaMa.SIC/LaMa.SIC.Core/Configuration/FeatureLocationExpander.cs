using Microsoft.AspNetCore.Mvc.Razor;

namespace LaMa.SIC.Core.Configuration
{
    public class FeatureLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var featureViewLocation = new string[] { "/Features/{1}/{0}.cshtml", "/Features/Shared/{0}.cshtml" };
            return featureViewLocation.Concat(viewLocations);
        }
    }
}