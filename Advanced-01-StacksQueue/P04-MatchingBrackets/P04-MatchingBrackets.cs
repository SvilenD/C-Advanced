using System;
using System.Collections.Generic;

namespace P04_MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int index = 0; index < input.Length; index++)
            {
                if (input[index] == '(')
                {
                    stack.Push(index);
                }
                else if (input[index] == ')')
                {
                    int start = stack.Pop();
                    int length = index - start + 1;
                    var subString = input.Substring(start, length);
                    Console.WriteLine(subString);
                }
            }
        }
    }
}