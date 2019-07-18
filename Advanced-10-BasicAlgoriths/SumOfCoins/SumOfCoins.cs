using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins // тъпия скелет на софтуни, винаги time limit
{
    public static void Main()
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");

        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var chosenCoins = new Dictionary<int, int>();

        var sortedCoins = coins
            .OrderByDescending(c => c)
            .ToList();

        int coinIndex = 0;
        int currentSum = 0;

        while (targetSum != currentSum && coinIndex < sortedCoins.Count)
        {
            var currentCoin = sortedCoins[coinIndex];

            if (currentCoin > targetSum - currentSum)
            {
                coinIndex++;
                continue;
            }

            if (chosenCoins.ContainsKey(currentCoin) == false)
            {
                chosenCoins.Add(currentCoin, 0);
            }

            chosenCoins[currentCoin]++;
            currentSum += currentCoin;
        }

        return chosenCoins;
    }
}