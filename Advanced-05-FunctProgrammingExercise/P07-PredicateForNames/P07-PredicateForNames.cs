namespace P07_PredicateForNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());

           var names = Console.ReadLine().Split();

            Action<string[]> printFiltered = x => 
            Console.WriteLine(string.Join(Environment.NewLine, 
            x.Where(s => s.Length <= length)));

            printFiltered(names);
        }
    }
}