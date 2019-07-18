namespace P01_EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            char[] symbolsToReplace = new char[] { '-', ',', '.', '!', '?' };
            int count = 0;
            using (var reader = new StreamReader("text.txt"))
            {
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (reader.EndOfStream == false)
                    {
                        var line = reader.ReadLine();

                        if (count % 2 == 0)
                        {
                            for (int i = 0; i < symbolsToReplace.Length; i++)
                            {
                                line = line.Replace(symbolsToReplace[i], '@');
                            }

                            var reversed = line.Split().Reverse();

                            writer.WriteLine(string.Join(" ", reversed));
                        }
                        count++;
                    }
                }
            }
        }
    }
}