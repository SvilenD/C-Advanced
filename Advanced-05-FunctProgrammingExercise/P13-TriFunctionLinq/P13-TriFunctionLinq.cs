using System;
using System.Linq;

namespace P13_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine(Console.ReadLine().Split()
                .FirstOrDefault(x => x.ToCharArray()
                .Select(y => (int)y).Sum() >= value));
        }
    }
}