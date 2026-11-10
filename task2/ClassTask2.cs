using System;
using System.Linq;

namespace task2
{
    public static class ClassTask2
    {
        private static bool IsVowel(char c)
            => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';

        public static bool IsAlternatingVowelConsonant(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;

            for (int i = 1; i < word.Length; i++)
            {
                if (IsVowel(word[i]) == IsVowel(word[i - 1]))
                    return false;
            }
            return true;
        }

        public static bool TryParseSequence(string input, out string[] words, out string error)
        {
            words = Array.Empty<string>();
            error = "";

            if (string.IsNullOrWhiteSpace(input))
            {
                error = "Строка не должна быть пустой.";
                return false;
            }

            string s = input.Trim();

            if (!s.EndsWith("."))
            {
                error = "В конце строки должна быть точка.";
                return false;
            }

            string core = s.Substring(0, s.Length - 1);

            if (core.Contains("."))
            {
                error = "Точка допускается только в конце строки.";
                return false;
            }

            string[] parts = core.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2 || parts.Length > 50)
            {
                error = "Количество слов должно быть от 2 до 50.";
                return false;
            }

            for (int i = 0; i < parts.Length; i++)
            {
                string w = parts[i];

                if (w.Length < 1 || w.Length > 8)
                {
                    error = $"Слово №{i + 1} должно быть длиной 1..8.";
                    return false;
                }

                if (!w.All(ch => ch >= 'a' && ch <= 'z'))
                {
                    error = $"Слово №{i + 1} должно содержать только строчные латинские буквы a-z.";
                    return false;
                }
            }

            words = parts;
            return true;
        }

        public static string[] GetRequiredWords(string[] words)
        {
            if (words == null || words.Length == 0) return Array.Empty<string>();

            string last = words[words.Length - 1];

            return words.Where(w => w != last && IsAlternatingVowelConsonant(w)).ToArray();
        }

        public static void Run()
        {
            Console.ResetColor();
            Console.Clear();

            SetColor("Задание 2: Введите 2..50 слов (a-z, 1..8), между словами пробел(ы), после последнего слова точка.\nСвойство - Чередуются гласные и согласные\n", ConsoleColor.DarkGray);

            string[] words = ReadValidSequence();

            string last = words[words.Length - 1];
            string[] result = GetRequiredWords(words);

            SetColor($"Последнее слово: {last}\n", ConsoleColor.DarkGray);

            if (result.Length == 0)
            {
                SetColor("Подходящих слов нет.", ConsoleColor.Yellow);
                return;
            }

            SetColor("Подходящие слова:", ConsoleColor.Green);
            foreach (string w in result)
                SetColor(w, ConsoleColor.Green);
        }

        private static string[] ReadValidSequence()
        {
            while (true)
            {
                Console.WriteLine("Введите последовательность слов по условию (последнее слово с точкой):");
                Console.Write("> ");
                string s = Console.ReadLine() ?? "";

                if (TryParseSequence(s, out string[] words, out string error))
                    return words;

                SetColor("ERROR: " + error + "\n", ConsoleColor.Red);
            }
        }

        private static void SetColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}