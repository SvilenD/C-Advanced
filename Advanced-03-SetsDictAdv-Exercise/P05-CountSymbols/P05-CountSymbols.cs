namespace P05_CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var symbolsCount = new SortedDictionary<char, int>();

            var input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                var symbol = input[i];
                if (symbolsCount.ContainsKey(symbol) == false)
                {
                    symbolsCount.Add(symbol, 0);
                }
                symbolsCount[symbol]++;
            }
            foreach (var symbol in symbolsCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}