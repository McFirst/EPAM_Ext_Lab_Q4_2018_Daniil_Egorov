namespace Task_3
{
    using System;
    using System.Text;

    /// <summary>
    /// задание 12
    /// </summary>
    public class Class312
    {
        public void Doubletter()
        {
            string deftxt1 = "abc.ab cde";//todo pn в ресурсы
            string deftxt2 = "bceb";
            string text1 = null;
            Console.Write("Введите первую строку [abc.ab cde]: ");//todo pn сильная связность
            text1 = Console.ReadLine();
            text1 = (text1 == string.Empty) ? deftxt1 : text1;
            string text2 = null;
            Console.Write("Введите вторую строку bceb: ");
            text2 = Console.ReadLine();
            text2 = (text2 == string.Empty) ? deftxt2 : text2;

            var result = new StringBuilder(string.Empty);
            foreach (char i in text1)
            {
                result.Append(i.ToString());
                result.Append(text2.Contains(i) ? i.ToString() : string.Empty);
            }

            Console.WriteLine("Итог: {0}", result.ToString());
        }
    }
}
