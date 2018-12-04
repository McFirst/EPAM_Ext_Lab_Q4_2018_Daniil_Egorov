namespace Task_3
{
    using System;

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
                Console.WriteLine("\t 13: Задание 3.13");

                if (menuitem == 0)
                {
                    menuitem = this.Readint("Введите пункт меню [1]: ", 1, 13);
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
                    case 13:
                        ////12 задание 
                        Class313 p13 = new Class313();
                        p13.Сomparison();
                        break;
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
