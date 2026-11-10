using System;

namespace task1
{
    public static class ClassTask1
    {
        public static string SwapPlusMinus(string expression)
        {
            if (expression == null) return "";

            char[] a = expression.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '+') a[i] = '-';
                else if (a[i] == '-') a[i] = '+';
            }
            return new string(a);
        }

        public static void Run()
        {
            Console.ResetColor();
            Console.Clear();

            SetColor("Задание 1: заменить \"+\" на \"-\" и \"-\" на \"+\"\n", ConsoleColor.DarkGray);

            string expr = ReadNonEmptyLine("Введите арифметическое выражение:");

            string result = SwapPlusMinus(expr);

            SetColor("\nРезультат:", ConsoleColor.Green);
            SetColor(result, ConsoleColor.Green);
        }

        private static string ReadNonEmptyLine(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                Console.Write("> ");
                string s = (Console.ReadLine() ?? "").Trim();

                if (s.Length > 0) return s;

                SetColor("ERROR: строка не должна быть пустой\n", ConsoleColor.Red);
            }
        }

        public static void SetColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}