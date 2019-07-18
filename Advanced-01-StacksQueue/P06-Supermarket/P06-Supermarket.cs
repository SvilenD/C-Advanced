using System;
using System.Collections.Generic;

namespace P06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Queue<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else if (input == "Paid")
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(input);
                }
            }
            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
