namespace P08_BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var opening = new List<char> { '{', '(', '[' };
            var closing = new List<char> { '}', ')', ']' };

            bool notBalanced = false;
            var parenthess = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (opening.Contains(symbol))
                {
                    parenthess.Push(symbol);
                }
                else
                {
                    if (parenthess.Count < 1)
                    {
                        notBalanced = true;
                        break;
                    }

                    int closeIndex = closing.IndexOf(symbol);
                    int openIndex = opening.IndexOf(parenthess.Pop());

                    if (openIndex != closeIndex)
                    {
                        notBalanced = true;
                        break;
                    }
                }
            }
            if (notBalanced)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}