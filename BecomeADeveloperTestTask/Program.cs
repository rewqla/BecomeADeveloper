using System;
using System.Collections.Generic;
using System.Linq;

namespace BecomeADeveloperTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text (press Enter twice to finish):");

            string text = ReadText();

            Console.WriteLine("Entered text:");
            Console.WriteLine(text);

            string[] words = text.Split();
            List<char> firstLetters = GetFirstLetters(words);

            char result = GetFirstUniqueLetter(firstLetters);

            if (result != '\0')
                Console.WriteLine("First unique symbol: " + result);
            else
                Console.WriteLine("Your text doesn't have any unique symbol");
        }

        private static string ReadText()
        {
            string text = "";
            string line;

            while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                text += line + "\n";
            }
            return text;
        }

        private static List<char> GetFirstLetters(string[] words)
        {
            List<char> firstLetters = new List<char>();

            foreach (var item in words)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    char c = GetLetter(item);
                    if (c != '\0')
                        firstLetters.Add(c);
                }
            }

            return firstLetters;
        }

        private static char GetLetter(string input)
        {
            foreach (var item in input)
            {
                if (char.IsLetter(item))
                {
                    return item;
                }
            }

            return '\0';
        }

        private static char GetFirstUniqueLetter(List<char> list)
        {
            foreach (var item in list)
            {
                if (list.Count(x => x == item) == 1)
                {
                    return item;
                }
            }

            return '\0';
        }
    }
}
