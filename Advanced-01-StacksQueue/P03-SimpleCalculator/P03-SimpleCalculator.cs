using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var stack = new Stack<string>(input.Reverse());

            int result = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                var symbol = stack.Pop();
                if (symbol == "+")
                {
                    result += int.Parse(stack.Pop());
                }
                else if (symbol =="-")
                {
                    result -= int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}
