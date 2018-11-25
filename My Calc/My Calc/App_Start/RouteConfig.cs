//-----------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Sprocket Enterprises">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// description namespace My_Calc
/// </summary>
namespace My_Calc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// description class RouteConfig
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// description RegisterRoutes
        /// </summary>
        /// <param name="routes">путь в строке адреса</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Calc", action = "Index", id = UrlParameter.Optional });
        }
    }
}
