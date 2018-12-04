namespace Task_3
{
    using System;

    /// <summary>
    /// ввод целочисленного числа
    /// </summary>
    public class Class30
    {
        public double Readint(string str, double defaultval, double maxval)
        {
            double result = 0;
            Console.Write(str);
            bool iscont = true;
            bool oncein = false;
            do
            {
                ConsoleKeyInfo keyPress = Console.ReadKey(true);
                char input = keyPress.KeyChar;

                iscont = !char.IsControl(input);

                if (char.IsDigit(input))
                {
                    Console.Write(input);
                    result = (result * 10) + char.GetNumericValue(input);
                    oncein = true;
                }
            }
            while (iscont);
            Console.WriteLine();

            if (oncein)
            {
                bool overmax = ((maxval == 0) ? false : true) & result > maxval;
                if (result == 0 | overmax)
                {
                    Console.WriteLine("Ошибка! Значение не может быть равно {0}. Введите еще раз!", result);
                    result = this.Readint(str, defaultval, maxval);
                }

                return result;
            }
            else
            {
                return defaultval;
            }
        }
    }
}
