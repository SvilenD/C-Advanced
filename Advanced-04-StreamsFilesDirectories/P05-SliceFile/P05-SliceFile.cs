namespace P05_SliceFile
{
using System;
using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new FileStream("05. Slice File/sliceMe.txt", FileMode.Open))
            {
                int filesCount = 4;
                for (int i = 1; i <= filesCount; i++)
                {
                    var partSize = Math.Ceiling((double)reader.Length / filesCount);
                    using (var writer = new FileStream($"05. Slice File/slice-{i}.txt.txt", FileMode.Create))
                    {
                        while (writer.Length < partSize)
                        {
                            int length = (int)Math.Min(4096, partSize - writer.Length);
                            var buffer = new byte[length];
                            int totalRead = reader.Read(buffer, 0, buffer.Length);

                            if (totalRead == 0)
                            {
                                break;
                            }
                            writer.Write(buffer, 0, totalRead);
                        }
                    }
                }
            }
        }
    }
}