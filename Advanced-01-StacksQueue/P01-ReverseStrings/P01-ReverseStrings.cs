using System;
using System.Collections.Generic;

namespace P01_ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}