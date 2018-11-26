//-----------------------------------------------------------------------
// <copyright file="CalcController.cs" company="Sprocket Enterprises">
//     Copyright (c) Sprocket Enterprises. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

/// <summary>
/// description namespace My_Calc.Controllers
/// </summary>
namespace My_Calc.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using My_Calc.Helpers;
    using My_Calc.Models;
    using My_Calc.Resources;

    /// <summary>
    /// class of calculator
    /// </summary>
    public class CalcController : Controller
    {
        /// <summary>
        /// default value x
        /// </summary>
        private const int DefaultX = 3;

        /// <summary>
        /// default value y
        /// </summary>
        private const int DefaultY = 32;

        /// <summary>
        /// default value result
        /// </summary>
        private const string DefaultResult = "No data";

        /// <summary>
        /// Gets or sets list of Results
        /// </summary>
        public static List<string> Results { get; protected set; } = new List<string>();

        // GET: Calc

        /// <summary>
        /// first page fo brauser
        /// </summary>
        /// <returns>this View</returns>
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// Calculate the sum of two integer variables
        /// </summary>
        /// <returns>this View</returns>
        public ActionResult Add()
        {
            return this.View(new CalcModel() { X = DefaultX, Y = DefaultY, Result = DefaultResult });
        }

        /// <summary>
        /// Calculate the sum of two integer variables
        /// </summary>
        /// <param name="model">раздел с расчетами калькулятора</param>
        /// <returns>this View</returns>
        [HttpPost]
        public ActionResult Add(CalcModel model)
        {
            double result = 0;
            string strerr = null;

            switch (model.Op)
            {
                case Operation.Add: result = model.X + model.Y;                     
                    break;
                case Operation.Sub: result = model.X - model.Y;
                    break;
                case Operation.Mult: result = model.X * model.Y;
                    break;
                case Operation.Divi: if (model.Y != 0)
                    {
                        result = model.X / model.Y;
                    }
                    else
                    {
                        strerr = "Division by 0";//todo pn строку в ресурсы
                    }

                    break;
            }

            string s = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");//todo pn такое лучше в константы выносить. Немнемоничное название переменной.

            if (strerr == null)
            {
                model.Result = string.Format("{0} | {1} {3} {2} = {4}\n", s, CalcResources.x, CalcResources.y, model.Op.DisplayName(), result);//todo pn здесь и ниже дублирование строк и кода
            }
            else
            {
                model.Result = string.Format("{0} | {1} {3} {2} = {4}\n", s, CalcResources.x, CalcResources.y, model.Op.DisplayName(), strerr);
            }

            Results.Add(model.Result);

            return this.View(model);
        }
    }
}