namespace Task_3
{
    using System;
    using System.Text;

    /// <summary>
    /// задание 2
    /// </summary>
    public class Class32 : Class30
    {
        public void Hierarchy(double countrow)
        {
            string symb = "*";
            var sb = new StringBuilder(string.Empty);
            for (int i = 0; i < countrow; i++)
            {
                sb.Append(symb);
                Console.WriteLine(sb);
            }
        }
    }
}
