namespace P04_MergeFiles
{
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var writer = new FileStream("Resources/MergedFile.txt", FileMode.Create))
            {
                using (var readerOne = new FileStream("Resources/FileOne.txt", FileMode.Open))
                {
                    while (true)
                    {
                        var firstBuffer = new byte[4096];
                        int firstText = readerOne.Read(firstBuffer, 0, firstBuffer.Length);
                        if (firstText == 0)
                        {
                            break;
                        }

                        writer.Write(firstBuffer, 0, firstText);
                    }
                }

                using (var readerTwo = new FileStream("Resources/FileTwo.txt", FileMode.Open))
                {
                    while (true)
                    {
                        byte[] secondBuffer = new byte[4096];
                        int secondText = readerTwo.Read(secondBuffer, 0, secondBuffer.Length);
                        if (secondText == 0)
                        {
                            break;
                        }
                        writer.Write(secondBuffer, 0, secondText);
                    }
                }
            }
        }
    }
}