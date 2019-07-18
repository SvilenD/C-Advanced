namespace P01_TojanInvasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrojanProg
    {
        static void Main()
        {
            int trojanWavesCount = int.Parse(Console.ReadLine());

            var spartaDefence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool spartaLost = false;
            Stack<int> trojanAttack = new Stack<int>();

            for (int i = 1; i <= trojanWavesCount; i++)
            {
                var currentWave = Console.ReadLine().Split().Select(int.Parse).ToArray();
                foreach (var num in currentWave)
                {
                    trojanAttack.Push(num);
                }

                if (i % 3 == 0)
                {
                    spartaDefence.Add(int.Parse(Console.ReadLine()));
                }

                while (trojanAttack.Count > 0 && spartaDefence.Sum() > 0)
                {
                    var currentAttack = trojanAttack.Pop();
                    if (currentAttack > spartaDefence[0])
                    {
                        currentAttack -= spartaDefence[0];
                        trojanAttack.Push(currentAttack);
                        spartaDefence.RemoveAt(0);
                    }
                    else if (currentAttack == spartaDefence[0])
                    {
                        spartaDefence.RemoveAt(0);
                    }
                    else
                    {
                        spartaDefence[0] -= currentAttack;
                    }
                }

                if (spartaDefence.Count < 1)
                {
                    spartaLost = true;
                    break;
                }
            }
            if (spartaLost)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", trojanAttack)}");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", spartaDefence)}");
            }
        }
    }
}