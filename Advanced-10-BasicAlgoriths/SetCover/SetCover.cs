using System;
using System.Collections.Generic;
using System.Linq;

public class SetCover
{
    public static void Main()
    {
        int[] universe = Console.ReadLine()
            .Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .Select(int.Parse)
            .ToArray();

        int setsCount = int.Parse(Console.ReadLine()
            .Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .LastOrDefault());

        int[][] sets = new int [setsCount][];

        for (int i = 0; i < setsCount; i++)
        {
            sets[i] = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        }

        List<int[]> selectedSets = ChooseSets(sets.ToList(), universe.ToList());
        Console.WriteLine($"Sets to take ({selectedSets.Count}):");

        foreach (int[] set in selectedSets)
        {
            Console.WriteLine($"{{ {string.Join(", ", set)} }}");
        }
    }

    public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
    {
        var selectedSets = new List<int[]>();

        while (universe.Count > 0)
        {
            var set = sets
                .OrderByDescending(s => s.Count(universe.Contains)).FirstOrDefault();
            selectedSets.Add(set);

            foreach (var num in set)
            {
                universe.Remove(num);
            }
        }

        return selectedSets;
    }
}