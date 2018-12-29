using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public static class ArraySum
    {
        /// <summary>
        /// считает сумму элементов массива int, double, decimal 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static ValueType SumArray<T>(this T[] param) 
        {
            ValueType result = default(ValueType);
            if (typeof(T) == typeof(int))
            {
                result = (param as IEnumerable<int>).Sum();
            }
            if (typeof(T) == typeof(double))
            {
                result = (param as IEnumerable<double>).Sum();
            }
            if (typeof(T) == typeof(decimal))
            {
                result = (param as IEnumerable<decimal>).Sum();
            }

            return result;
        }
    }
}
