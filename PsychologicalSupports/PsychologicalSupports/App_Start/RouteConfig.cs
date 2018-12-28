﻿using System.Web.Mvc;
using System.Web.Routing;

namespace PsychologicalSupports
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default2",
                url: "{controller}/{action}/{id}/{id2}",
                defaults: new { id = UrlParameter.Optional,id2= UrlParameter.Optional}
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Students", action = "Index", id = UrlParameter.Optional }
                );
        }
    }
}
