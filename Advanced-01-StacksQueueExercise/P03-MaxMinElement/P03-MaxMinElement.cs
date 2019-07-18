using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MaxMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "1")
                {
                    int num = int.Parse(input[1]);
                    stack.Push(num);
                }
                else if (stack.Count > 0)
                {
                    if (input[0] == "2")
                    {
                        stack.Pop();
                    }
                    else if (input[0] == "3")
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (input[0] == "4")
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}