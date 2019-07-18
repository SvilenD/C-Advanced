using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var rackCapacity = int.Parse(Console.ReadLine());

            var clothes = new Stack<int>(input);

            int racks = 1;
            int sum = 0;

            while (clothes.Count > 0)
            {
                if (sum + clothes.Peek() <= rackCapacity)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}