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
        public static decimal SumArray(this int[] param)
        {
            decimal result = 0;
            foreach (int i in param)
            {
                result += i;
            }
            return result;
        }
    }
}
