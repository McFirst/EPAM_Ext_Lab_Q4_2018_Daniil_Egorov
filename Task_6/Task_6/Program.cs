using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[] { "abcd", "pcd", "abcde", "bbc", "a" };
            SortLength sl = new SortLength();
            sl.RegisterComp(onStrcompare);

            foreach (string i in lines)
                Console.WriteLine(i);
            Console.WriteLine();

            foreach (string i in sl.StringSort(lines))
                Console.WriteLine(i);

            //Console.WriteLine(String.Compare("abc", "pbc"));
            Console.ReadLine();
        }

        public static bool onStrcompare(string str1, string str2)
        {
            bool ret = false;
            if (str1.Length > str2.Length)
                ret = true;
            else if (str1.Length == str2.Length)
            {
                if (String.Compare(str1, str2) > 0)
                    ret = true;
            }
            return ret;
        }
    }
}
