namespace Task_3
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Text;

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

    /// <summary>
    /// задание 1
    /// </summary>
    public class Class31 : Class30
    {
        public double Square(double a1, double b1)
        {
            double x = a1 * b1;
            return x;
        }
    }

    /// <summary>
    /// задание 2
    /// </summary>
    public class Class32 : Class30
    {
        public void Hierarchy(double countrow)
        {
            var sb = new StringBuilder(string.Empty);
            for (int i = 0; i < countrow; i++)
            {
                sb.Append("*");
                Console.WriteLine(sb.ToString());
            }
        }
    }

    /// <summary>
    /// задание 3
    /// </summary>
    public class Class33 : Class30
    {
        public void Pipyramid(double countrow, double indent)
        {
            var sb = new StringBuilder(string.Empty);
            for (int i = 1; i < countrow + indent; i++)
            {
                sb.Append(" ");
            }

            sb.Append("*");
            for (int i = 0; i < countrow; i++)
            {
                Console.WriteLine(sb.ToString());
                sb.Replace(" *", "***");
            }
        }
    }

    /// <summary>
    /// задание 4
    /// </summary>
    public class Class34 : Class33
    {
        public void Еriangle(double countta)
        {
            for (int i = 1; i < countta; i++)
            {
                this.Pipyramid(i, countta - i);
            }
        }
    }

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
                    Console.Write("{0}, ", i);
                    result = result + i;
                }
            }

            Console.WriteLine();
            return result;
        }
    }

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
                iscont = ((input == (char)13) | input == '\u001b') ? true : false;

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
            if (input != '\u001b')
            {
                int numpar = Convert.ToInt32(Math.Floor(result));
                this.status[numpar - 1] = !this.status[numpar - 1];
                this.Font();
            }
        }
    }

    /// <summary>
    /// задание 7 https://ru.wikipedia.org/wiki/Гномья_сортировка
    /// </summary>
    public class Class37
    {
        public void Gnomsort()
        {
            int[] mass = new int[5];
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write("{0}  ", mass[i] = rand.Next(100));
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
                Console.Write("{0}  ", mass[i] = rand.Next(-10, 10));
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

    /// <summary>
    /// задание 11
    /// </summary>
    public class Class311
    {
        public void Avaword()
        {
            string text = null;
            string defstr = "abc.ab abcd";
            Console.Write("Введите строку [{0}]: ", defstr);
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
                Console.WriteLine("В строке нет ни одного слова!");
            }
            else
            {
                Console.WriteLine("Средняя Длина слова: {0}", countchar / countword);
            }
        }
    }

    /// <summary>
    /// задание 12
    /// </summary>
    public class Class312
    {
        public void Doubletter()
        {
            string deftxt1 = "abc.ab cde";
            string deftxt2 = "bceb";
            string text1 = null;
            Console.Write("Введите первую строку [abc.ab cde]: ");
            text1 = Console.ReadLine();
            text1 = (text1 == string.Empty) ? deftxt1 : text1;
            string text2 = null;
            Console.Write("Введите вторую строку bceb: ");
            text2 = Console.ReadLine();
            text2 = (text2 == string.Empty) ? deftxt2 : text2;

            var result = new StringBuilder(string.Empty);
            foreach (char i in text1)
            {
                result.Append(i.ToString());
                result.Append(text2.Contains(i) ? i.ToString() : string.Empty);
            }

            Console.WriteLine("Итог: {0}", result.ToString());
        }
    }

    /// <summary>
    /// задание 13
    /// </summary>
    public class Class313
    {
        public void Сomparison()
        {
            for (int j = 0; j < 1000; j++)
            {
                string str = string.Empty;
                StringBuilder sb = new StringBuilder();
                int n = 250000;
                Stopwatch swstr = new Stopwatch();
                Stopwatch swsb = new Stopwatch();

                swstr.Start();
                for (int i = 0; i < n; i++)
                {
                    str += "*";
                }

                swstr.Stop();

                swsb.Start();
                for (int i = 0; i < n; i++)
                {
                    sb.Append("*");
                }

                swsb.Stop();

                StringBuilder text = new StringBuilder(string.Empty);
                TimeSpan ts = swstr.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                text.Append(j.ToString() + "\n");
                text.Append("RunTime String " + elapsedTime + "\n");
                
                ts = swsb.Elapsed;
                elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                text.Append("RunTime StringBulder " + elapsedTime + "\n" + "\n");
                Console.Write(text.ToString());
                
                string path = @"D:\work\epam\labs\Task 3\Task 3\13.txt";
                File.AppendAllText(path, text.ToString());
            }
        }
    }

    /// <summary>
    /// меню
    /// </summary>
    public class Menu : Class30
    {
        public void MainMenu()
        {
            double menuitem = 0;
            ConsoleKeyInfo keyPress = new ConsoleKeyInfo();
            do
            {
                ///menu
                Console.Clear();
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("\t 1:  Задание 3.1");
                Console.WriteLine("\t 2:  Задание 3.2");
                Console.WriteLine("\t 3:  Задание 3.3");
                Console.WriteLine("\t 4:  Задание 3.4");
                Console.WriteLine("\t 5:  Задание 3.5");
                Console.WriteLine("\t 6:  Задание 3.6");
                Console.WriteLine("\t 7:  Задание 3.7");
                Console.WriteLine("\t 8:  Задание 3.8");
                Console.WriteLine("\t 9:  Задание 3.9");
                Console.WriteLine("\t 10: Задание 3.10");
                Console.WriteLine("\t 11: Задание 3.11");
                Console.WriteLine("\t 12: Задание 3.12");
                ///Console.WriteLine("\t 13: Задание 3.13");

                if (menuitem == 0)
                {
                    menuitem = this.Readint("Введите пункт меню [1]: ", 1, 12);
                }

                Console.Clear();
                switch (menuitem)
                {
                    case 1:
                        ////первое задание
                        Console.WriteLine("01. Вычисление площади прямоугольника со сторонами a и b");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        Class31 p1 = new Class31();
                        Console.WriteLine(p1.Square(p1.Readint("Введите сторону a [6]: ", 6, 0), p1.Readint("Введите сторону b [3]: ", 3, 0)));
                        break;
                    case 2:
                        ////второе задание
                        Console.WriteLine("02. Выводит на экран лесенку из N ступеней, но не больше 50");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        Class32 p2 = new Class32();
                        p2.Hierarchy(p2.Readint("Введите количество строк [10]: ", 10, 50));
                        break;
                    case 3:
                        ////3 задание
                        Class33 p3 = new Class33();
                        Console.WriteLine("03. Выводит на экран пирамиду из N ступеней, но не больше 50");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        p3.Pipyramid(p3.Readint("Введите количество строк [10]: ", 10, 50), 0);
                        break;
                    case 4:
                        ////4 задание
                        Console.WriteLine("04. Выводит на экран елку из N треугольников, но не больше 50");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        Class34 p4 = new Class34();
                        p4.Еriangle(p4.Readint("Введите количество строк [5]: ", 5, 50));
                        break;
                    case 5:
                        ////5 задание
                        Console.WriteLine("05. Выводит на экран список и сумму натуральных чисел в диапазоне от 0 до 1000");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        Class35 p5 = new Class35();
                        Console.WriteLine("Сумма = {0}", p5.Sumnum(p5.Readint("Введите максимальное значение [50]: ", 50, 1000), p5.Readint("Введите первое кратное [5]: ", 5, 1000), p5.Readint("Введите второе кратное [7]: ", 7, 1000)));
                        break;
                    case 6:
                        ////6 задание
                        Console.WriteLine("06. Выводит на экран управление форматом шрифта");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        Class36 p6 = new Class36();
                        p6.Font();
                        break;
                    case 7:
                        ////7 задание
                        Console.WriteLine("07. Сортируем массив со случайными числами по алгоритму гномьей сортировки.");
                        Class37 p7 = new Class37();
                        p7.Gnomsort();
                        break;
                    case 8:
                        ////8 задание
                        Console.WriteLine("08. Заменяет все положительные элементы в 3D-массиве на 0.");
                        Class38 p8 = new Class38();
                        p8.Mass3d();
                        break;
                    case 9:
                        ////9 задание
                        Console.WriteLine("09. Определяет сумму неотрицательных элеметов в 1D-массиве.");
                        Class39 p9 = new Class39();
                        p9.Mass1d();
                        break;
                    case 10:
                        ////10 задание
                        Console.WriteLine("10. Определяет сумму элементов 2D-массива, стоящих на чётных позициях.");
                        Class310 p10 = new Class310();
                        p10.Mass2d();
                        break;
                    case 11:
                        ////11 задание 
                        Console.WriteLine("11. Определяет среднюю длину слова во введенной текстовой строке.");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        Class311 p11 = new Class311();
                        p11.Avaword();
                        break;
                    case 12:
                        ////12 задание 
                        Console.WriteLine("12. Удваивает в первой введенной строки все символы, принадлежащие второй введенной строке.");
                        Console.WriteLine("В поле запроса в скобках отображается значение по умолчанию.");
                        Class312 p12 = new Class312();
                        p12.Doubletter();
                        break;
                        ////case 13:
                        ////    ////12 задание 
                        ////    Class313 p13 = new Class313();
                        ////    p13.Сomparison();
                        ////    break;
                }

                Console.WriteLine();
                Console.WriteLine(" To REPEAT  task pess 'r' \n Go to MENU, press 'm' \n press any key to exit");
                keyPress = Console.ReadKey(true);
                menuitem = (keyPress.Key == ConsoleKey.R) ? menuitem : 0;
            }
            while ((keyPress.Key == ConsoleKey.M) | (keyPress.Key == ConsoleKey.R));
        }
    }
}
