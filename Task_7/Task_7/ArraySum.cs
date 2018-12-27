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
        /// считает сумму элементов массива int
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T SumArray<T>(this T[] param)
        { 
            T result=default(T);
            foreach (T i in param)
            {
                result = result + i;
            }
            return result;
        }
    }
}
