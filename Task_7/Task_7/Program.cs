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
        public static T[] SimpeHigher<T>(this T[] param, T threshold) where T:IComparable<T>
        {
            List<T> result = new List<T>(3);
            foreach (T i in param)
            {
                if(i.CompareTo(threshold)>0) { result.Add(i); }               
            }

            return result.ToArray();
        }

        /// <summary>
        /// Возвращает все положительные значения массива через делегат только int
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T[] HigherByDeleg<T>(this T[] param, Matching<T> comp, T threshold)
        {
            List<T> result = new List<T>(3);
            foreach (var i in param)
            {
                if (comp(i, threshold)) result.Add(i);
            }
            return result.ToArray();
        }

        public static T[] HigherByDeleg2<T>(this T[] param, Matching2<T> comp)
        {
            List<T> result = new List<T>(3);
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
        public static T[] HigherByLINQ<T>(this T[] param, T threshold) where T : IComparable<T>
        {
            T[]  result = null;
            result = (from i in param
                      where i.CompareTo(threshold) > 0
                      select i).ToArray();
            return result;
        }

        /// <summary>
        /// условие - делегат
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool Condition<T>(T param, T threshold) where T : IComparable<T>
        {
            return  param.CompareTo(threshold) > 0;
        }

        /// <summary>
        /// тип делегата-условия
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public delegate bool Matching<T>(T param, T threshold);
        public delegate bool Matching2<T>(T param);

        static void Main(string[] args)
        {
            ////задание 1
            Console.WriteLine("================= 7.1 =================");
            int[] arr = new int[] { 1, 2, 3, 4 };
            double[] arr1 = new double[] { 1.5, 2, 3, 4 };
            Console.WriteLine(arr.SumArray());
            Console.WriteLine(arr1.SumArray());

            ////задание 2
            Console.WriteLine("\n================= 7.2 =================");
            string str = "21";
            Console.WriteLine(str.IsPositiveInt());

            ////задание 3
            Console.WriteLine("\n================= 7.3 =================");
            Stopwatch sw = new Stopwatch();
            List<decimal> timing = new List<decimal>(5);
            int sizearr = 1000000;
            int min = -100;
            int max = 100;
            int[] arr3 = new int[sizearr];
            Random rnd = new Random();

            for (var i=0; i< arr3.Length;i++)
            {
                arr3[i] = rnd.Next(min, max);
            }

            ////Console.WriteLine("Input value:");
            ////foreach (var i in arr3)
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            Console.WriteLine("\n Method 1:");
            sw.Reset();
            sw.Start();
            arr3.SimpeHigher(0);
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            ////foreach (var i in arr3.SimpeHigher(0))
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            Console.WriteLine("\n Method 2:");
            sw.Reset();
            sw.Start();
            arr3.HigherByDeleg(Condition, 0);
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            ////foreach (var i in arr3.HigherByDeleg(Condition,0))
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            Console.WriteLine("\n Method 3:");
            sw.Reset();
            sw.Start();
            arr3.HigherByDeleg2(delegate (int param)
            {
                return param > 0;
            });
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            ////var res = arr3.HigherByDeleg2(delegate (double param) 
            ////{ 
            ////    return param > 0; 
            ////});
            ////foreach (var i in res)
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            Console.WriteLine("\n Method 4:");
            sw.Reset();
            sw.Start();
            arr3.HigherByDeleg2(param => param > 0);
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            ////foreach (var i in arr3.HigherByDeleg2(param => param > 0))
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            Console.WriteLine("\n Method 5:");
            sw.Reset();
            sw.Start();
            arr3.HigherByLINQ(0);
            timing.Add(sw.ElapsedMilliseconds);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            ////foreach (var i in arr3.HigherByLINQ(0))
            ////{
            ////    Console.Write($"{i}  ");
            ////}

            //foreach (decimal i in timing) { Console.WriteLine(i); }
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }       
    }
}
