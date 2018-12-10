namespace Task_3
{
    using System;
    using System.Text;

    /// <summary>
    /// задание 6
    /// </summary>
    public class Class36 : Class30
    {
        private bool[] status = new bool[] { false, false, false };
        private string[] fonttype = new string[] { "bold", "italic", "underline" };

        public void Font()
        {
            var fontres = new StringBuilder(string.Empty);
            for (int i = 0; i < 3; i++)
            {
                ///отображение текущего формата перед началом выбора
                fontres.Append(this.status[i] ? (this.fonttype[i] + " ") : string.Empty);
            }

            Console.WriteLine("Параметры текста: {0}", (fontres.ToString() == string.Empty) ? "None" : fontres.ToString());
            Console.WriteLine("Парметры: \n" +
                "          1: bold \n" +
                "          2: italic \n" +
                "          3: underline");
            double result = 1;
            Console.Write("Введите номер параметра [1]: ");
            bool iscont = true;
            char input;
            do
            {
                ConsoleKeyInfo keyPress = Console.ReadKey(true);
                input = keyPress.KeyChar;
                ///ограничение на управлющие Enter и ESC
                iscont = ((input == (char)13) | input == '\u001b') ? true : false;//todo pn хардкод

                if (char.IsDigit(input))
                {
                    ///вводим только 1 2 3, остальное игнорируем
                    if (char.GetNumericValue(input) > 0 & char.GetNumericValue(input) < 4)
                    {
                        Console.Write(input);
                        result = char.GetNumericValue(input);
                    }
                }
            }
            while (!iscont);
            Console.WriteLine();

            ///если ESC то прервать рекрсию
            if (input != '\u001b')//todo pn хардкод
            {
                int numpar = Convert.ToInt32(Math.Floor(result));
                this.status[numpar - 1] = !this.status[numpar - 1];
                this.Font();
            }
        }
    }
}
