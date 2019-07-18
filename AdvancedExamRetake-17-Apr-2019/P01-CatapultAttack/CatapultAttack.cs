namespace CatapultAttack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int pilesCount = int.Parse(Console.ReadLine());

            var spartaFortress = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i <= pilesCount; i++)
            {
                var trojanAttack = new Stack<int>(Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray());

                if (i % 3 == 0)
                {
                    var newWall = int.Parse(Console.ReadLine());
                    spartaFortress.Add(newWall);
                }

                while (trojanAttack.Count > 0)
                {
                    var attack = trojanAttack.Pop();
                    var wall = spartaFortress[0] - attack;
                    attack -= spartaFortress[0];

                    if (wall <= 0)
                    {
                        spartaFortress.RemoveAt(0);
                    }
                    else
                    {
                        spartaFortress[0] = wall;
                    }

                    if (attack > 0)
                    {
                        trojanAttack.Push(attack);
                    }

                    if (spartaFortress.Count <= 0)
                    {
                        Console.WriteLine($"Rocks left: {string.Join(", ", trojanAttack)}");
                        return;
                    }
                }
            }

            Console.WriteLine($"Walls left: {string.Join(", ", spartaFortress)}");
        }
    }
}