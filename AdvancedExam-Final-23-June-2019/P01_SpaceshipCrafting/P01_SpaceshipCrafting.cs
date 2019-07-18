namespace SpaceshipCrafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        internal enum Materials
        {
            Glass = 25,
            Aluminium = 50,
            Lithium = 75,
            CarbonFiber = 100
        }

        public static void Main()
        {
            var materials = new SortedDictionary<string, int>();
            materials.Add("Glass", 0);
            materials.Add("Aluminium", 0);
            materials.Add("Lithium", 0);
            materials.Add("Carbon fiber", 0);

            var chemicalLiquids = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var physicalItems = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (chemicalLiquids.Count > 0 && physicalItems.Count > 0)
            {
                var chemical = chemicalLiquids.Dequeue();
                var physical = physicalItems.Pop();
                if (chemical + physical == (int)Materials.Glass)
                {
                    materials["Glass"]++;
                }
                else if (chemical + physical == (int)Materials.Aluminium)
                {
                    materials["Aluminium"]++;
                }
                else if (chemical + physical == (int)Materials.Lithium)
                {
                    materials["Lithium"]++;
                }
                else if (chemical + physical == (int)Materials.CarbonFiber)
                {
                    materials["Carbon fiber"]++;
                }
                else
                {
                    physicalItems.Push(physical + 3);
                }
            }

            if (materials.All(x => x.Value > 0))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            if (chemicalLiquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (physicalItems.Count > 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}