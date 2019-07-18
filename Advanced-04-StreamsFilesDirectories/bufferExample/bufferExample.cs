using System;
using System.IO;

namespace bufferExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("writerTest.txt"))
            {
                int count = 1;
                char[] buffer = new char[5] { 'b', 'a', 'h', 'u', 'r' };
                while (count < 20)
                {
                    //var text = $"{count}. {new string(buffer)}";
                    //writer.WriteLine(text);
                    writer.Write(buffer, 0, buffer.Length);
                    writer.Flush(); // изпраща данните преди да се e затворил стрийма

                    count++;
                }
            }

            using (var reader = new StreamReader("Input.txt"))
            {
                while (reader.EndOfStream == false)
                {
                    char[] buffer = new char[16];

                    int total = reader.Read(buffer, 0, buffer.Length);

                    for (int i = 0; i < total; i++)
                    {
                        Console.Write(buffer[i]);    
                    }
                }
            }
        }
    }
}
