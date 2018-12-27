using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[] { 1, 2, 3, 4 };
            double[] arr1 = new double[] { 1.5, 2, 3, 4 };
            //decimal result = arr.SumArray();
            Console.WriteLine(arr.SumArray());
            Console.WriteLine(arr1.SumArray());


            ////string param = "21";

            //////param.IsPositiveInt();

            ///////int i = Convert.ToInt32(param);
            ////Console.WriteLine(param.IsPositiveInt());
            Console.ReadKey();
        }
    }
}
