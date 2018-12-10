namespace Task_3
{
    using System;

    /// <summary>
    /// задание 9
    /// </summary>
    public class Class39
    {
        public void Mass1d()
        {
            int[] mass = new int[10];
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0}  ", mass[i] = rand.Next(-10, 10));//todo pn хардкод
            }

            Console.WriteLine();

            int result = 0;
            foreach (int i in mass)
            {
                result += (i > 0) ? i : 0;
            }

            Console.WriteLine("Сумма неотрицательныхчисел = {0}", result);
        }
    }
}
