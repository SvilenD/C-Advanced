namespace P03_WordCount
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
            var words = new StringBuilder();
            using (var wordsReader = new StreamReader("words.txt"))
            {
                while (wordsReader.EndOfStream == false)
                {
                    var buffer = new char[16];
                    int length = wordsReader.Read(buffer, 0, buffer.Length);
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        words.Append(buffer[i]);
                    }
                }
            }

            var wordsSplit = words.ToString().Split();
            var wordsDict = new Dictionary<string, int>();

            foreach (var word in wordsSplit.Where(w => w != string.Empty))
            {
                wordsDict.Add(word, 0);
            }

            using (var textReader = new StreamReader("../../../text.txt"))
            {
                string text = string.Empty;
                while (textReader.EndOfStream == false)
                {
                    text += textReader.ReadLine();
                }

                foreach (var word in text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?', '-', '\"', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (wordsDict.ContainsKey(word.ToLower()))
                    {
                        wordsDict[word.ToLower()]++;
                    }
                }
            }

            using (var expectedReader = new StreamReader("../../../expectedResult.txt"))
            {
                using (var writer = new StreamWriter("../../../actualResult.txt"))
                {
                    foreach (var kvp in wordsDict.OrderByDescending(x => x.Value))
                    {
                        var actual = $"{kvp.Key} - {kvp.Value}";
                        var expected = expectedReader.ReadLine();
                        if (actual == expected)
                        {
                            writer.WriteLine(actual);
                            Console.WriteLine($"Correct Entry! Expected: {expected}, Actual: {actual}.");
                        }
                        else
                        {
                            Console.WriteLine($"Wrong result! Expected: {expected}, Actual: {actual}.");
                            return;
                        }
                    }
                }
            }
        }
    }
}