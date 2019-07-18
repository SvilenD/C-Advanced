namespace P03_WordCountFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var splitSymbols = new char[] { ' ', ',', '.', ':', ';', '!', '?', '-', '\"', '\r', '\n' };
            string[] words = File.ReadAllText("words.txt").Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
            var wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                wordsCount.Add(words[i].ToLower(), 0);
            }

            string[] text = File.ReadAllText("text.txt").Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in text)
            {
                if (wordsCount.ContainsKey(word?.ToLower()))
                {
                    wordsCount[word.ToLower()]++;
                }
            }

            StringBuilder result = new StringBuilder();
            foreach (var word in wordsCount)
            {
                var input = $"{word.Key} - {word.Value}";
                result.AppendLine(input);
            }
            File.WriteAllText("../../../actualResult.txt", result.ToString());

            result.Clear();
            foreach (var word in wordsCount.OrderByDescending(x => x.Value))
            {
                var input = $"{word.Key} - {word.Value}";
                result.AppendLine(input);
            }
            File.WriteAllText("../../../expectedResult.txt", result.ToString());
        }
    }
}