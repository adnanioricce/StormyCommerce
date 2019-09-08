using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using System.Threading.Tasks;

namespace StormyCommerce.Api.Framework.Extensions
{
    public class UrlSlugRoute : IRouter
    {
        private readonly IRouter _target;

        public UrlSlugRoute(IRouter target)
        {
            _target = target;
        }

        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            throw new System.NotImplementedException();
        }

        public async Task RouteAsync(RouteContext context)
        {
            var requestPath = context.HttpContext.Request.Path.Value;

            if (!string.IsNullOrEmpty(requestPath) && requestPath[0] == '/')
            {
                // Trim the leading slash
                requestPath = requestPath.Substring(1);
            }

            var urlSlugRepository = context.HttpContext.RequestServices.GetService<IStormyRepository<Entity>>();

            // Get the slug that matches.
            var urlSlug = await urlSlugRepository.Table
                .Include(x => x.EntityType)
                .FirstOrDefaultAsync(x => x.Slug == requestPath);

            // Invoke MVC controller/action
            var oldRouteData = context.RouteData;
            var newRouteData = new RouteData(oldRouteData);
            newRouteData.Routers.Add(_target);

            // If we got back a null value set, that means the URI did not match)
            if (urlSlug == null)
            {
                return;
            }

            newRouteData.Values["area"] = urlSlug.EntityType.AreaName;
            newRouteData.Values["controller"] = urlSlug.EntityType.RoutingController;
            newRouteData.Values["action"] = urlSlug.EntityType.RoutingAction;
            newRouteData.Values["id"] = urlSlug.EntityId;

            context.RouteData = newRouteData;
            await _target.RouteAsync(context);
        }
    }
}
