using System;
using task1;
using task2;
using task3;

namespace main.Console
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                System.Console.ResetColor();
                System.Console.Clear();

                ClassTask1.SetColor("Чумачек В.С, бИЦ-252\nЛабораторная работа №5, вариант №6\n", ConsoleColor.DarkGray);

                System.Console.WriteLine("|Меню:");
                System.Console.WriteLine("|1. > Задание 1 (замена знаков \"+\" и \"-\")");
                System.Console.WriteLine("|2. > Задание 2 (последовательность, удовлетворяющая свойству)");
                System.Console.WriteLine("|3. > Задание 3 (кол-во слов)");
                System.Console.Write("|0. > Выход");
                System.Console.Write("\n> ");
                int numMenu = 0;
                while (!int.TryParse((System.Console.ReadLine() ?? "").Trim(), out numMenu) || numMenu < 0 || numMenu > 3)
                {
                    ClassTask1.SetColor("ERROR: Введите пункт меню от 0 до 3", ConsoleColor.Red);
                    System.Console.Write("> ");
                }
                System.Console.WriteLine();

                switch (numMenu)
                {
                    case 1:
                        ClassTask1.Run();
                        Pause();
                        break;
                    case 2:
                        ClassTask2.Run();
                        Pause();
                        break;
                    case 3:
                        ClassTask3.Run();
                        Pause();
                        break;
                    case 0:
                        return;
                }
            }
        }

        static void Pause()
        {
            System.Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить");
            System.Console.ReadKey(true);
        }

        
    }
}