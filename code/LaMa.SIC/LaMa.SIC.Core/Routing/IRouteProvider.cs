namespace LaMa.SIC.Core.Routing
{
    public interface IRouteProvider
    {
        IEnumerable<RouteDescriptor> GetRoutes();
    }
}