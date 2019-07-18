namespace P02_LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader("text.txt"))
            {
                char[] marks = new char[] { '.', ',', ':', '?', '!', ';', '-', '\'' };
                int number = 1;
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (reader.EndOfStream == false)
                    {
                        int lettersCount = 0;
                        int marksCount = 0;
                        var line = reader.ReadLine();
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (marks.Contains(line[i]))
                            {
                                marksCount++;
                            }
                            else if (char.IsLetter(line[i]))
                            {
                                lettersCount++;
                            }
                        }
                        writer.WriteLine($"Line {number}: {line} ({lettersCount})({marksCount})");
                    }
                }
            }
        }
    }
}