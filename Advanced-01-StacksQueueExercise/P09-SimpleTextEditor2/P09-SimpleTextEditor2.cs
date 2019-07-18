namespace P09_SimpleTextEditor2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class StartUp
    {
        public static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var textStack = new Stack<string>();

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
                if (command == "1")
                {
                    textStack.Push(text.ToString());

                    text.Append(input[1]);
                }
                else if (command == "2")
                {
                    textStack.Push(text.ToString());

                    int index = int.Parse(input[1]);
                    text.Remove(text.Length - index, index);

                }
                else if (command == "3")
                {
                    int index = int.Parse(input[1]);

                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4" && textStack.Count > 0)
                {
                    text.Clear();
                    text.Append(textStack.Pop());

                }
            }
        }
    }
}