namespace P01_ActionPoint
{
using System;

    public class Program
    {
        public static void Main()
        {
            Action<string> print = x => Console.WriteLine(x);
            var input = Console.ReadLine().Split();
            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}