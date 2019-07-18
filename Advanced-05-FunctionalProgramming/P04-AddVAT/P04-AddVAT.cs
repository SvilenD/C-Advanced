using System;
using System.Linq;

namespace P04_AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => double.Parse(p) * 1.2)
                .ToArray();
            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }            
        }
    }
}
