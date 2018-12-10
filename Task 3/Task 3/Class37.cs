namespace Task_3
{
    using System;

    /// <summary>
    /// задание 7 https://ru.wikipedia.org/wiki/Гномья_сортировка
    /// </summary>
    public class Class37
    {
        public void Gnomsort()
        {
            int randnum = 100;
            int[] mass = new int[5];
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0}  ", mass[i] = rand.Next(randnum));
            }

            Console.WriteLine();

            int k = 1;
            while (k < mass.Length)
            {
                if (mass[k - 1] < mass[k])
                {
                    k++;
                }
                else
                {
                    int z = mass[k - 1];
                    mass[k - 1] = mass[k];
                    mass[k] = z;
                    k--;
                    if (k == 0)
                    {
                        k++;
                    }
                }
            }

            foreach (int i in mass)
            {
                Console.Write("{0}  ", i);
            }

            Console.WriteLine();
        }
    }
}
