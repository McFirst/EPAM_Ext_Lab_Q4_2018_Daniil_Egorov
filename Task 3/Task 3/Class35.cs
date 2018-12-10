namespace Task_3
{
    using System;

    /// <summary>
    /// задание 5
    /// </summary>
    public class Class35 : Class30
    {
        public double Sumnum(double maxnum, double divider1, double divider2)
        {
            double result = 0;
            for (int i = 1; i < maxnum + 1; i++)
            {
                if ((i % divider1 == 0) | (i % divider2 == 0))
                {
                    Console.Write("{0}, ", i);//todo pn сильная связность
                    result = result + i;
                }
            }

            Console.WriteLine();
            return result;
        }
    }
}
