namespace P01_ActionPoint
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Action<string> print = p => Console.WriteLine(string.Join(Environment.NewLine, p.Split()));
            //Action<string> print = p => p.Split().ToList().ForEach(Console.WriteLine);
            var input = Console.ReadLine();
            print(input);
        }
    }
}
