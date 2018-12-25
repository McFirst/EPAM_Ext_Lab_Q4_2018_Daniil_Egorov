namespace Task_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            /*string[] lines = new string[] { "abcd", "pcd", "abcde", "bbc", "a" };
            SortLength sl = new SortLength();
            sl.RegisterComp(OnStrcompare);

            foreach (string i in lines)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            foreach (string i in sl.StringSort(lines))
            {
                Console.WriteLine(i);
            }
            */

            List<Person> u1 = new List<Person>(3);
            u1.Add(new Person("Abraam"));
            u1.Add(new Person("Boris"));
            u1.Add(new Person("Donn"));

            Office office = new Office();
            foreach(Person i in u1)
            {
                office.Income += i.Hi;
            }
            //office.Income;

            Console.ReadLine();
        }

        /// <summary>
        /// сравнение двух строк (возвращает true если надо менять местами)
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool OnStrcompare(string str1, string str2)
        {
            bool ret = false;
            if (str1.Length > str2.Length)
            {
                ret = true;
            }
            else if (str1.Length == str2.Length)
            {
                if (string.Compare(str1, str2) > 0)
                {
                    ret = true;
                }
            }

            return ret;
        }
    }
}
