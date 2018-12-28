using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public static class PositiveInt
    {
        /// <summary>
        /// Является ли строка положительным целым числом, иначе False
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static bool IsPositiveInt(this string param)
        {
            /// System.FormatException
            bool result = false;
            try
            {
                if(Convert.ToInt32(param)>0)
                {
                    result = true;
                }

            }
            catch(System.FormatException e)
            {
                /// лог ошибки
            }
            return result;
        }

        /// <summary>
        /// Является ли строка положительным целым числом, иначе False
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static bool IsPositive(this string param)
        {
            /// System.FormatException
            bool result = false;
            try
            {
                if (param.GetType() == typeof(int))
                {
                    if (Convert.ToInt32(param) > 0) { result = true; }
                }
                if (param.GetType() == typeof(double))
                {
                    if (Convert.ToDouble(param) > 0) { result = true; }
                }
                if (param.GetType() == typeof(decimal))
                {
                    if (Convert.ToDecimal(param) > 0) { result = true; }
                }

            }
            catch (System.FormatException e)
            {
                /// лог ошибки
            }
            return result;
        }
    }
}
