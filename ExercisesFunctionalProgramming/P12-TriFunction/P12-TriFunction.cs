namespace P12_TriFunction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int value = int.Parse(Console.ReadLine());

            Func<string, int, bool> higherValue = (n, v) => n.Sum(c => c) >= v;

            var names = Console.ReadLine().Split();

            Func<string[], Func<string, int, bool>, string> nameFilter = (n, hV) 
                => n.FirstOrDefault(x => higherValue(x, value));

            Console.WriteLine(nameFilter(names, higherValue));
        }
    }
}