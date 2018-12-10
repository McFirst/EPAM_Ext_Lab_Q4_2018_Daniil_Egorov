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
            int randmin = -10;
            int randmax = 10;
            int[] mass = new int[10];
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0}  ", mass[i] = rand.Next(randmin, randmax));
            }

            Console.WriteLine();

            int result = 0;
            foreach (int i in mass)
            {
                result += (i > 0) ? i : 0;
            }

            Console.WriteLine("Sum of non-negative numbers = {0}", result);
        }
    }
}
