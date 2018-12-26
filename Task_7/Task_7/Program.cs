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
            /*
            int[] arr = new int[] { 1, 2, 3, 4 };
            decimal result = arr.SumArray();
            Console.WriteLine(result);
            */

            string param = "21";

            //param.IsPositiveInt();

            ///int i = Convert.ToInt32(param);
            Console.WriteLine(param.IsPositiveInt());
            Console.ReadKey();
        }
    }
}
