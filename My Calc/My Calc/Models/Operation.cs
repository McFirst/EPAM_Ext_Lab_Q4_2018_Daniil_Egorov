//-----------------------------------------------------------------------
// <copyright file="Operation.cs" company="Sprocket Enterprises">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// description namespace My_Calc.Models
/// </summary>
namespace My_Calc.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using My_Calc.Resources;

    /// <summary>
    /// description enum Operation
    /// </summary>
    public enum Operation
    {
        [Display(Name = "Add", ResourceType = typeof(CalcResources))]

        /// <summary>
        /// description Add
        /// </summary>
        Add,
        [Display(Name = "Sub", ResourceType = typeof(CalcResources))]

        /// <summary>
        /// description Sub
        /// </summary>
        Sub,
        [Display(Name = "Mult", ResourceType = typeof(CalcResources))]

        /// <summary>
        /// description Mult
        /// </summary>
        Mult,
        [Display(Name = "Divi", ResourceType = typeof(CalcResources))]

        /// <summary>
        /// description Divi
        /// </summary>
        Divi
    }
}