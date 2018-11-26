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
        /// format datetime
        /// </summary>
        private const string formatdate = "dd MMMM yyyy | HH:mm:ss";

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
                        strerr = CalcResources.div0;//перенес строку в ресурсы
                    }

                    break;
            }

            string datenow = DateTime.Now.ToString(formatdate);//формат даты в константах. Нормальное название переменной.

            model.Result = string.Format("{0} | {1} {3} {2} = {4}\n", datenow, CalcResources.x, CalcResources.y, model.Op.DisplayName(), strerr ?? result.ToString());//подставил оператор объединения
            

            Results.Add(model.Result);

            return this.View(model);
        }
    }
}