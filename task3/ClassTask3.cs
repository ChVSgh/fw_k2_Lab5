using System;

namespace task3
{
    public static class ClassTask3
    {
        public static int CountWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;

            string[] parts = sentence.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return parts.Length;
        }

        public static void Run()
        {
            Console.ResetColor();
            Console.Clear();

            SetColor("Задание 3: подсчитать количество слов в предложении (между словами может быть несколько пробелов)\n",
                ConsoleColor.DarkGray);

            Console.WriteLine("Введите предложение:");
            Console.Write("> ");
            string s = Console.ReadLine() ?? "";

            int count = CountWords(s);

            SetColor($"\nКоличество слов: {count}", ConsoleColor.Green);
        }

        private static void SetColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}