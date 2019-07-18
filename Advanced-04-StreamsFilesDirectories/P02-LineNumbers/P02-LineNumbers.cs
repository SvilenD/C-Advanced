using System;
using System.IO;

namespace P02_LineNumbers
{
    class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader("Resourses/Input.txt"))
            {
                using (var writer = new StreamWriter("Resourses/Output.txt")) //, true за дописване на файла при всяко ново стартиране , encoding...
                {
                    int counter = 1;
                    while (reader.EndOfStream == false)
                    {
                        var line = reader.ReadLine();
                        line = $"{counter}. {line}";

                        writer.WriteLine(line);
                        counter++;
                    }
                }
            }
        }
    }
}