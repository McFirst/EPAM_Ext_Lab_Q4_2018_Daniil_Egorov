namespace Task_3
{
    using System;

    /// <summary>
    /// задание 8
    /// </summary>
    public class Class38
    {
        public void Mass3d()
        {
            int[,,] mass = new int[4, 3, 2];
            Random rand = new Random();

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    for (int k = 0; k < mass.GetLength(2); k++)
                    {
                        mass[i, j, k] = rand.Next(-10, 10);
                    }
                }
            }

            for (int k = 0; k < mass.GetLength(2); k++)
            {
                Console.WriteLine("Первый срез по z = {0}", k + 1);
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", mass[i, j, k]);
                        if (mass[i, j, k] > 0)
                        {
                            mass[i, j, k] = 0;
                        }
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("Измененный масив");
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                Console.WriteLine("Первый срез по z = {0}", k + 1);
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", mass[i, j, k]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
