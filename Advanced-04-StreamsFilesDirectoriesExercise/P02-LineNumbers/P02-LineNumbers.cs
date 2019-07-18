namespace P02_LineNumbers_File
{
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var lines = File.ReadLines("../../../text.txt").ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                int lettersCount = lines[i].Count(char.IsLetter);
                int marksCount = lines[i].Count(char.IsPunctuation);
                lines[i] = $"Line{i + 1}: {lines[i]} ({lettersCount})({marksCount})";
            }
            File.WriteAllLines("../../../output.txt", lines);
        }
    }
}