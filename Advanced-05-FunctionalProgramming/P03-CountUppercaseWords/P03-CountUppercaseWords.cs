using System;
using System.Linq;

namespace P03_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                //.Where(w=>w[0] == w.ToUpper()[0]) 
                //Where(checker) 
                .Where(w => char.IsUpper(w[0]))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}