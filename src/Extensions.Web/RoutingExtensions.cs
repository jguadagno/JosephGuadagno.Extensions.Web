using System.Web.Routing;

namespace JosephGuadagno.Extensions.Web
{
    /// <summary>
    /// Extensions of System.Web.Routing
    /// </summary>
    public static class RoutingExtensions
    {
        /// <summary>
        /// Adds a page to route table
        /// </summary>
        /// <param name="routes">The <see cref="RouteCollection"/></param>
        /// <param name="routeName">The name for the route</param>
        /// <param name="routeUrl">The Url for the route</param>
        /// <param name="physicalFile">The physical file to route to</param>
        /// <param name="checkPhysicalUrlAccess">Indicates if you want to make sure the physical page exists</param>
        /// <param name="defaults">Default values for the route collection</param>
        /// <param name="constraints">Constraints for the route collection</param>
        /// <param name="dataTokens">Data Tokens for the route collection</param>
        /// <param name="dataTokenKey">The key to use to store the route in the DataTokens list.</param>
        public static void MapPageRouteWithName(this RouteCollection routes, string routeName, string routeUrl,
            string physicalFile, bool checkPhysicalUrlAccess = true,
            RouteValueDictionary defaults = default(RouteValueDictionary),
            RouteValueDictionary constraints = default(RouteValueDictionary),
            RouteValueDictionary dataTokens = default(RouteValueDictionary), string dataTokenKey = "route-name")
        {
            if (dataTokens == null)
                dataTokens = new RouteValueDictionary();

            dataTokens.Add(dataTokenKey, routeName);
            routes.MapPageRoute(routeName, routeUrl, physicalFile, checkPhysicalUrlAccess, defaults, constraints,
                dataTokens);
        }

        /// <summary>
        /// Retrieves a route name for a given key
        /// </summary>
        /// <param name="routeData">The <see cref="RouteData"/></param>
        /// <param name="dataTokenKey">The key to use to store the route in the DataTokens list.</param>
        /// <returns>The name of the route.</returns>
        public static string GetRouteName(this RouteData routeData, string dataTokenKey = "route-name")
        {
            return routeData.DataTokens[dataTokenKey]?.ToString() ?? string.Empty;
        }
    }
}