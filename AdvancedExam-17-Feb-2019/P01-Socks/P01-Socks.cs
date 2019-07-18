namespace P01_Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var leftSocks = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            var rightSocks = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            var setsOfSocks = new List<int>();

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int leftSock = leftSocks.Pop();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    setsOfSocks.Add(leftSock + rightSock);
                    rightSocks.Dequeue();
                }
                else if(leftSock == rightSock)
                {
                    rightSocks.Dequeue();
                    leftSocks.Push(leftSock + 1);
                }
            }

            Console.WriteLine(setsOfSocks.Max());
            Console.WriteLine($"{string.Join(' ', setsOfSocks)}");
        }
    }
}