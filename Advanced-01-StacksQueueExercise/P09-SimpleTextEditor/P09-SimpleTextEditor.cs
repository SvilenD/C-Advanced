namespace P09_SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StatUp
    {
        public static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var stack = new Stack<string>();

            string text = string.Empty;
            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "1")
                {
                    text += input[1];
                    stack.Push(text);
                }
                else if (input[0] == "2")
                {
                    int count = int.Parse(input[1]);
                    text = text.Substring(0, text.Length - count);
                    stack.Push(text);
                }
                else if (input[0] == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text.ElementAtOrDefault(index - 1));
                }
                else if (input[0] == "4")
                {
                    if (stack.Count > 1)
                    {
                        stack.Pop();
                        text = stack.Peek();
                    }
                    else
                    {
                        text = string.Empty;
                    }
                }
            }
        }
    }
}