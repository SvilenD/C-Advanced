using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P03_WordCount2
{
    class Program
    {
        static void Main()
        {
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            var wordsFromFile = File.ReadAllText("03. Word Count/words.txt").Split();

            var wordsCounter = new Dictionary<string, int>();
            for (int i = 0; i < wordsFromFile.Length; i++)
            {
                wordsCounter.Add(wordsFromFile[i], 0);
            }

            var textFromFile = File.ReadAllText("03. Word Count/text.txt")
                .Split(new char[] { ' ', ',', '.', '?', '!', ':', '-', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in textFromFile)
            {
                if (wordsCounter.ContainsKey(word.ToLower()))
                {
                    wordsCounter[word.ToLower()]++;
                }
            }

            using (var writer = new FileStream("03. Word Count/Output.txt", FileMode.OpenOrCreate))
            {
                foreach (var word in wordsCounter.OrderByDescending(w => w.Value))
                {
                    var line = $"{word.Key} - {word.Value}";
                    byte[] outputText = Encoding.UTF8.GetBytes(line);
                    writer.Write(outputText);

                    byte[] newLine = Encoding.UTF8.GetBytes(Environment.NewLine);
                    writer.Write(newLine);
                }
            }


            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.Elapsed }"); stopwatch.ToString();
        }
    }
}