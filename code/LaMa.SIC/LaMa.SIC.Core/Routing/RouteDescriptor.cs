namespace LaMa.SIC.Core.Routing
{
    public class RouteDescriptor
    {
        public string AssemblyNamespace { get; private set; }
        public string RouteName { get; private set; }
        public string RouteUrlFormat { get; private set; }
        public object Defaults { get; private set; }
        public int Priority { get; set; }
        public static RouteDescriptor Create(string assemblyNamespace)
        {
            return new RouteDescriptor
            {
                AssemblyNamespace = assemblyNamespace,
            };
        }

        public RouteDescriptor SetPriority(int priority)
        {
            Priority = Priority;
            return this;
        }
        public RouteDescriptor SetRouteUrlFormat(string routeName, string routeUrlFormat)
        {
            RouteName = routeName;
            RouteUrlFormat = routeUrlFormat;
            return this;
        }
        public RouteDescriptor SetDefaults(object routeDefaults)
        {
            Defaults = routeDefaults;
            return this;
        }
    }
}