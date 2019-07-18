using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09_SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var textVersions = new Stack<string>();
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "1")
                {
                    textVersions.Push(text.ToString());
                    string textToAdd = input[1];
                    text.Append(textToAdd);
                }
                else if (input[0] == "2")
                {
                    textVersions.Push(text.ToString());
                    int count = int.Parse(input[1]);
                    text = text.Remove(text.Length - count, count);
                }
                else if (input[0] == "3")
                {
                    int index = int.Parse(input[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (input[0] == "4")
                {
                    text.Clear();
                    if (textVersions.Count > 1)
                    {
                        text.Append(textVersions.Pop());
                    }
                }
            }
        }
    }
}