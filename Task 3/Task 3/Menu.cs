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
                Console.WriteLine("Choose task:");
                Console.WriteLine("\t 1:  Task 3.1");
                Console.WriteLine("\t 2:  Task 3.2");
                Console.WriteLine("\t 3:  Task 3.3");
                Console.WriteLine("\t 4:  Task 3.4");
                Console.WriteLine("\t 5:  Task 3.5");
                Console.WriteLine("\t 6:  Task 3.6");
                Console.WriteLine("\t 7:  Task 3.7");
                Console.WriteLine("\t 8:  Task 3.8");
                Console.WriteLine("\t 9:  Task 3.9");
                Console.WriteLine("\t 10: Task 3.10");
                Console.WriteLine("\t 11: Task 3.11");
                Console.WriteLine("\t 12: Task 3.12");
                Console.WriteLine("\t 13: Task 3.13");

                if (menuitem == 0)
                {
                    menuitem = this.Readint("Enter menu item [1]: ", 1, 13);
                }

                Console.Clear();
                switch (menuitem)
                {
                    case 1:
                        ////первое задание
                        Class31 p1 = new Class31();
                        Console.WriteLine(p1.Square(p1.Readint("Enter side a [6]: ", 6, 0), p1.Readint("Enter side b [3]: ", 3, 0)));
                        break;
                    case 2:
                        ////второе задание
                        Class32 p2 = new Class32();
                        p2.Hierarchy(p2.Readint("Enter the number of lines [10]: ", 10, 50));
                        break;
                    case 3:
                        ////3 задание
                        Class33 p3 = new Class33();
                        p3.Pipyramid(p3.Readint("Enter the number of lines [10]: ", 10, 50), 0);
                        break;
                    case 4:
                        ////4 задание
                        Class34 p4 = new Class34();
                        p4.Еriangle(p4.Readint("Enter the number of lines [5]: ", 5, 50));
                        break;
                    case 5:
                        ////5 задание
                        Class35 p5 = new Class35();
                        Console.WriteLine("Summ = {0}", p5.Sumnum(p5.Readint("Enter maximum value [50]: ", 50, 999), p5.Readint("Enter the first multiple [5]: ", 5, 1000), p5.Readint("Enter the second multiple [7]: ", 7, 1000)));
                        break;
                    case 6:
                        ////6 задание
                        Class36 p6 = new Class36();
                        p6.Font();
                        break;
                    case 7:
                        ////7 задание
                        Class37 p7 = new Class37();
                        p7.Gnomsort();
                        break;
                    case 8:
                        ////8 задание
                        Class38 p8 = new Class38();
                        p8.Mass3d();
                        break;
                    case 9:
                        ////9 задание
                        Class39 p9 = new Class39();
                        p9.Mass1d();
                        break;
                    case 10:
                        ////10 задание
                        Class310 p10 = new Class310();
                        p10.Mass2d();
                        break;
                    case 11:
                        ////11 задание 
                        Class311 p11 = new Class311();
                        p11.Avaword();
                        break;
                    case 12:
                        ////12 задание 
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
