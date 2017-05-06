using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5Course
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{myparam}/{action}/{mydate}/{controller}/{id}",
                defaults: new {
                    mydate = DateTime.Today.ToString(),
                    myparam = "test",
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional }
            );
        }
    }
}
