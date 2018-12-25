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
            Console.WriteLine("Task 6.1:");
            Console.WriteLine("");
            string[] lines = new string[] { "abcd", "pcd", "abcde", "bbc", "a" };
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

            Console.WriteLine("");
            Console.WriteLine("============================================");
            Console.WriteLine("");
            Console.WriteLine("Task 6.2:");
            Console.WriteLine("");

            List<Person> u1 = new List<Person>(3);
            Person user1 = new Person("Abraam");
            Person user2 = new Person("Boris");
            Person user3 = new Person("Donn");

            user1.ComeInOffice(user1, 11, u1);
            user2.ComeInOffice(user2, 12, u1);
            user3.ComeInOffice(user3, 18, u1);

            user1.LeaveOffice(user1, u1);
            user2.LeaveOffice(user2, u1);
            user3.LeaveOffice(user3, u1);

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
