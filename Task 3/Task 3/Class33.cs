namespace Task_3
{
    using System;
    using System.Text;

    /// <summary>
    /// задание 3
    /// </summary>
    public class Class33 : Class30
    {
        public void Pipyramid(double countrow, double indent)
        {
            var sb = new StringBuilder(string.Empty);
            for (int i = 1; i < countrow + indent; i++)
            {
                sb.Append(" ");
            }

            sb.Append("*");//todo pn хардкод
            for (int i = 0; i < countrow; i++)
            {
                Console.WriteLine(sb.ToString());//todo pn сильная связность
                sb.Replace(" *", "***");//todo pn хардкод
            }
        }
    }
}
