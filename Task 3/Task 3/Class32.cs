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
            var sb = new StringBuilder(string.Empty);
            for (int i = 0; i < countrow; i++)
            {
                sb.Append("*");//todo pn хардкод
                Console.WriteLine(sb.ToString());//todo pn сильная связность
            }
        }
    }
}
