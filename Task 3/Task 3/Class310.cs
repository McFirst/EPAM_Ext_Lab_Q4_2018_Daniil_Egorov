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
            int randmin = -10;
            int randmax = 10;
            int[,] mass = new int[5, 4];
            Random rand = new Random();
            int result = 0;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write("{0}\t", mass[i, j] = rand.Next(randmin, randmax));
                    result += ((i + j) % 2 == 0) ? mass[i, j] : 0;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Sum of even positions = {0}", result);
        }
    }
}
