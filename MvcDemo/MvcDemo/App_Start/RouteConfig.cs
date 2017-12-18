using MvcDemo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcDemo
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            SessionManager.GetInstance.sMessage = "Loggedin";
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "tblEmployees", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
