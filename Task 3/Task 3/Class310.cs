namespace Task_3
{
    using System;

    /// <summary>
    /// задание 10
    /// </summary>
    public class Class310
    {
        public void Mass2d()
        {
            int[,] mass = new int[5, 4];
            Random rand = new Random();
            int result = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write("{0}\t", mass[i, j] = rand.Next(-10, 10));
                    result += ((i + j) % 2 == 0) ? mass[i, j] : 0;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Сумма четных позиций = {0}", result);
        }
    }
}
