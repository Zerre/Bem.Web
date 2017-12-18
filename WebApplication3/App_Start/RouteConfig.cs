using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Sinema",
                url: "sinema/tur/{tur}",
                defaults: new { controller = "Sinema", action = "Tur" }
            );

            routes.MapRoute(
                name: "SinemaZamani",
                url: "sinema/tarih/{neZaman}",
                defaults: new { controller = "Sinema", action = "Tarih" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
