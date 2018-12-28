using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public static class Program
    {
        /// <summary>
        /// Возвращает все положительные значения массива int, double, decimal
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T[] SimpeSort<T>(this T[] param)
        {
            List<T> result = new List<T>(3);
            foreach (T i in param)
            {
                if(i.ToString().IsPositive()) { result.Add(i); }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Возвращает все положительные значения массива через делегат только int
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int[] SortByDeleg(this int[] param, Matching comp)
        {
            List<int> result = new List<int>(3);

            foreach (var i in param)
            {
                if (comp(i)) result.Add(i);
            }

            return result.ToArray();
        }

        /// <summary>
        /// Возвращает все положительные значения массива через LINQ
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T[] SortByLINQ<T>(this T[] param)
        {
            T[]  result = null;
            result = (from i in param
                      where i.ToString().IsPositive()
                      select i).ToArray();
            return result;
        }

        /// <summary>
        /// сравнение
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public static bool Conv<T>(T arg1, T arg2)
        {
            bool result = false;
            if (arg1.GetType() == typeof(int))
            {
                result = Convert.ToInt32(arg1) > Convert.ToInt32(arg2);
            }
            if (arg1.GetType() == typeof(double))
            {
                result = Convert.ToDouble(arg1) > Convert.ToInt32(arg2);
            }
            if (arg1.GetType() == typeof(decimal))
            {
                result = Convert.ToDecimal(arg1) > Convert.ToInt32(arg2);
            }

            return result;
        }

        /// <summary>
        /// условие - делегат
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool Condition(int param)
        {
            return param > 0;
        }
        
        /// <summary>
        /// тип делегата-условия
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public delegate bool Matching(int param);
        
        static void Main(string[] args)
        {
            ////////задание 1
            ////int[] arr = new int[] { 1, 2, 3, 4 };
            ////double[] arr1 = new double[] { 1.5, 2, 3, 4 };
            ////Console.WriteLine(arr.SumArray());
            ////Console.WriteLine(arr1.SumArray());

            ////////задание 2
            ////string param = "21";
            ////bool res = param.IsPositiveInt();
            ////Console.WriteLine(param.IsPositiveInt());

            ////задание 3
            Stopwatch sw = new Stopwatch();
            List<decimal> timing = new List<decimal>(5);
            int sizearr = 1000000;
            int min = -100;
            int max = 100;
            int[] arr3 = new int[sizearr];
            Matching comp = new Matching(Condition);
            Random rnd = new Random();

            for (int i=0; i< arr3.Length;i++)
            {
                arr3[i] = rnd.Next(min, max);
            }

            //Console.WriteLine("Input value:");
            //foreach (int i in arr3)
            //{
            //    Console.Write($"{i}  ");
            //}

            //Console.WriteLine("\n Method 1:");
            sw.Reset();
            sw.Start();
            arr3.SimpeSort();
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            ////foreach (int i in arr3.SimpeSort())
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            ////Console.WriteLine("\n Method 2:");
            sw.Reset();
            sw.Start();
            arr3.SortByDeleg(comp);
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            ////foreach (int i in arr3.SortByDeleg(comp))
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            ////Console.WriteLine("\n Method 3:");
            sw.Reset();
            sw.Start();
            arr3.SortByDeleg(delegate (int param)
                {
                    return param > 0;
                });
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            ////foreach (int i in arr3.SortByDeleg(delegate (int param)
            ////    {
            ////        return param > 0;
            ////    }))
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            ////Console.WriteLine("\n Method 4:");
            sw.Reset();
            sw.Start();
            arr3.SortByDeleg(param => param > 0);
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            ////foreach (int i in arr3.SortByDeleg(param => param > 0))
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            //Console.WriteLine("\n Method 5:");
            sw.Reset();
            sw.Start();
            arr3.SortByLINQ();
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            //foreach (int i in arr3.SortByLINQ())
            //{
            //    Console.Write($"{i}  ");
            //}

            foreach (decimal i in timing) { Console.WriteLine(i); }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }       
    }
}
