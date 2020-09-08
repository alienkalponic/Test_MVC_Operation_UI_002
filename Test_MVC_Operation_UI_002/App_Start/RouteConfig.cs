using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Test_MVC_Operation_UI_002
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "registration page view",
                url: "Registration_Modeluse/person_registration",
                defaults: new { controller = "Registration_Modeluse", action = "saveUser" }
            );
            routes.MapRoute(
                name: "registration data Insert",
                url: "Registration_Modeluse/registration-insert-data",
                defaults: new { controller = "Registration_Modeluse", action = "Registration_Data_Save" }
            );
            routes.MapRoute(
                name: "registration data show",
                url: "Registration_Modeluse/table-data-show",
                defaults: new { controller = "Registration_Modeluse", action = "GET_Data_Show" }
            );
            routes.MapRoute(
                name: "registration data search",
                url: "Registration_Modeluse/table-data-search",
                defaults: new { controller = "Registration_Modeluse", action = "GET_Data_Search" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
