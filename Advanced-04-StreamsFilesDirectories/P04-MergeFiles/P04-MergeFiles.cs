namespace P04_MergeFiles
{
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var writer = new StreamWriter("Resources/Merged.txt"))
            {
                using (var readerOne = new StreamReader("Resources/FileOne.txt"))
                {
                    using (var readerTwo = new StreamReader("Resources/FileTwo.txt"))
                    {
                        while (readerOne.EndOfStream == false || readerTwo.EndOfStream == false)
                        {
                            var bufferOne = readerOne.ReadLine();
                            if (bufferOne != null)
                            {
                                writer.WriteLine(bufferOne);
                            }
                            var bufferTwo = readerTwo.ReadLine();
                            if (bufferTwo != null)
                            {
                                writer.WriteLine(bufferTwo);
                            }
                        }
                    }
                }
            }
        }
    }
}