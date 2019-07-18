using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P03_WordCount
{
    class Program
    {
        static void Main()
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            var words = new StringBuilder();
            using (var wordsReader = new StreamReader("03. Word Count/words.txt"))
            {
                while (wordsReader.EndOfStream == false)
                {
                    char[] buffer = new char[16];

                    int total = wordsReader.Read(buffer, 0, buffer.Length);

                    for (int i = 0; i < total; i++)
                    {
                        words.Append(buffer[i]);
                    }
                }
            }

            var textFromFile = new StringBuilder();
            using (var text = new StreamReader("03. Word Count/text.txt"))
            {
                while (text.EndOfStream == false)
                {
                    char[] buffer = new char[16];

                    int total = text.Read(buffer, 0, buffer.Length);

                    for (int i = 0; i < total; i++)
                    {
                        textFromFile.Append(buffer[i]);
                    }
                }
            }

            Dictionary<string, int> wordsCounter = CountWords(words, textFromFile);

            using (var writer = new StreamWriter("03. Word Count/Output.txt"))
            {
                foreach (var word in wordsCounter.OrderByDescending(w=>w.Value))
                {
                    var line = $"{word.Key} - {word.Value}";
                    writer.Write(line + Environment.NewLine);
                    writer.Flush(); // изпраща данните преди да се e затворил стрийма
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed }"); stopwatch.ToString();
        }

        private static Dictionary<string, int> CountWords(StringBuilder words, StringBuilder textFromFile)
        {
            var wordsCounter = new Dictionary<string, int>();
            var wordsArray = words.ToString().Split();

            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordsCounter.Add(wordsArray[i], 0);
            }
            foreach (var word in textFromFile.ToString().Split(new char[] { ' ', '.', ',', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries))
            {
                for (int i = 0; i < wordsArray.Length; i++)
                {
                    if (wordsArray[i] == word.ToLower())
                    {
                        wordsCounter[word.ToLower()]++;
                    }
                }
            }
            return wordsCounter;
        }
    }
}