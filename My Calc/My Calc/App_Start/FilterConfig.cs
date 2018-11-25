//-----------------------------------------------------------------------
// <copyright file="FilterConfig.cs" company="Sprocket Enterprises">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// description namespace My_Calc
/// </summary>
namespace My_Calc
{
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// description class FilterConfig
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// description RegisterGlobalFilters
        /// </summary>
        /// <param name="filters">Initializes a new instance of the System.Web.Mvc</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
