namespace P07_PredicateForNames
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split();

            Func<string[], int, string[]> filter = (n, f) => n.Where(x => x.Length <= f).ToArray();

            Action<string[]> print = n => 
                Console.WriteLine(string.Join(Environment.NewLine, n));

            print(filter(names, length));
        }
    }
}