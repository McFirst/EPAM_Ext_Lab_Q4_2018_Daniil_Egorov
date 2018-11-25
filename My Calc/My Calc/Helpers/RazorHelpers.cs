//-----------------------------------------------------------------------
// <copyright file="RazorHelpers.cs" company="Sprocket Enterprises">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// description namespace My_Calc.Helpers
/// </summary>
namespace My_Calc.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// description class RazorHelpers
    /// </summary>
    public static class RazorHelpers
    {
        /// <summary>
        /// description DisplayName whot we see
        /// </summary>
        /// <param name="value">some value of this</param>
        /// <returns>name in outString </returns>
        public static string DisplayName(this Enum value)
        {
            Type enumType = value.GetType();
            var enumValue = Enum.GetName(enumType, value);
            MemberInfo member = enumType.GetMember(enumValue)[0];

            var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
            var outString = ((DisplayAttribute)attrs[0]).Name;

            if (((DisplayAttribute)attrs[0]).ResourceType != null)
            {
                outString = ((DisplayAttribute)attrs[0]).GetName();
            }

            return outString;
        }
    }
}