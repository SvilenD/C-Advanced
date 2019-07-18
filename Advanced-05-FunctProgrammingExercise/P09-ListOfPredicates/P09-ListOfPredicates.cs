using System;
using System.Collections.Generic;
using System.Linq;

public class program
{
    static HashSet<int> dividers;
    public static void Main()
    {
        var endNumber = int.Parse(Console.ReadLine());

        dividers = Console.ReadLine().Split()
                .Select(int.Parse).ToHashSet();

        Queue<int> numbers = new Queue<int>();

        for (int num = 1; num <= endNumber; num++)
        {
            if (IsValid(num))
            {
                numbers.Enqueue(num);
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }

    public static bool IsValid(int num)
    {
        Func<int, int, bool> notDivisible = (number, div) => number % div != 0;

        foreach (var divisor in dividers)
        {
            if (notDivisible(num, divisor))
            {
                return false;
            }
        }
        return true;
    }
}