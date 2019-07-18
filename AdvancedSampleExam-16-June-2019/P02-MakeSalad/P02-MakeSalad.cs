namespace P02_MakeSalad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var vegCalories = new Dictionary<string, int>();
            vegCalories.Add("tomato", 80);
            vegCalories.Add("carrot", 136);
            vegCalories.Add("lettuce", 109);
            vegCalories.Add("potato", 215);

            var vegetables = new Queue<string>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries));

            var calories = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            var readySalads = new Queue<int>();
            while (vegetables.Count > 0 && calories.Count > 0)
            {
                var salad = calories.Peek();
                readySalads.Enqueue(calories.Pop()); 
                while (salad > 0 && vegetables.Count > 0)
                {
                    string currentVeg = vegetables.Dequeue();
                    int currentVegCalories = vegCalories.FirstOrDefault(v => v.Key == currentVeg).Value;
                    salad -= currentVegCalories;
                }
            }

            Console.WriteLine($"{string.Join(' ', readySalads)}");
            if (vegetables.Count > 0)
            {
                Console.WriteLine($"{string.Join(' ', vegetables)}");
            }
            if (calories.Count > 0)
            {
                Console.WriteLine($"{string.Join(' ', calories)}");
            }

        }
    }
}