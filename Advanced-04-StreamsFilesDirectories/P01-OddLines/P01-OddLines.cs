namespace P01_OddLines
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var inputFile = "Input.txt";    // right click - properties -> copy if newer ==> Input.txt
            var folder = "../../../01. Odd Lines";
            var outputFile = "Output.txt";
            var filePath = Path.Combine(folder, inputFile);

            using (var reader = new StreamReader(filePath)) 
            {
                var outputFolder = new FileInfo(filePath).Directory.ToString();
                using (var writer = new StreamWriter(Path.Combine(outputFolder, outputFile)))
                {
                    int count = 0;
                    while (reader.EndOfStream == false)
                    {
                        var line = reader.ReadLine();
                        //if (line == null)
                        //{
                        //    break;
                        //}
                        if (count % 2 != 0)
                        {
                            Console.WriteLine(line);
                            writer.WriteLine(line);
                            writer.Flush();
                        }
                        count++;
                    }
                }
            }
        }
    }
}