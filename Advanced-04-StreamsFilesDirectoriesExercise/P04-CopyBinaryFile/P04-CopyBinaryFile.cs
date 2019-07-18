namespace P04_CopyBinaryFile
{
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (var reader = new FileStream("copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream("../../../newCopy.png", FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];
                        int size = reader.Read(buffer, 0, buffer.Length);
                        if (size == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, size);
                        writer.Flush();
                    }
                }

            }
        }
    }
}