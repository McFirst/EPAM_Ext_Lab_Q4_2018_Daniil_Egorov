namespace Task_3
{
    using System;

    /// <summary>
    /// задание 11
    /// </summary>
    public class Class311
    {
        public void Avaword()
        {
            string text = null;
            string defstr = "abc.ab abcd";
            Console.Write("Enter the string [{0}]: ", defstr);//todo pn сильная связность ????
            text = Console.ReadLine();
            if (text == string.Empty)
            {
                text = defstr;
            }

            decimal countchar = 0;
            decimal countword = 0;
            bool separ = true;

            foreach (char i in text)
            {
                if (char.IsPunctuation(i) | char.IsSeparator(i))
                {
                    countword += separ ? 0 : 1;
                    separ = true;
                }
                else
                {
                    countchar++;
                    separ = false;
                }
            }

            countword += separ ? 0 : 1;
            if (countword == 0)
            {
                Console.WriteLine("There are no words in the line!");
            }
            else
            {
                Console.WriteLine("Average word length: {0}", countchar / countword);
            }
        }
    }
}
