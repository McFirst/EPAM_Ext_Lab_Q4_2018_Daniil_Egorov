//-----------------------------------------------------------------------
// <copyright file="CalcModel.cs" company="Sprocket Enterprises">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// description namespace My_Calc.Models
/// </summary>
namespace My_Calc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using My_Calc.Resources;

    /// <summary>
    /// description class CalcModel
    /// </summary>
    public class CalcModel
    {
        [Display(Name = "x", ResourceType = typeof(CalcResources))]
        [Required]

        /// <summary>
        /// Gets or sets X
        /// </summary>
        public double X { get; set; }

        [Display(Name = "y", ResourceType = typeof(CalcResources))]
        [Required]

        /// <summary>
        /// Gets or sets Y
        /// </summary>
        public double Y { get; set; }

        [Display(Name = "Result", ResourceType = typeof(CalcResources))]

        /// <summary>
        /// Gets or sets Result
        /// </summary>
        public string Result { get; set; }

        [Display(Name = "OpName", ResourceType = typeof(CalcResources))]

        /// <summary>
        /// Gets or sets Op
        /// </summary>
        public Operation Op { get; set; }
    }
}