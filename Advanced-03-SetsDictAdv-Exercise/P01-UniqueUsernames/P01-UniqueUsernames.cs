namespace P01_UniqueUsernames
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            var usernames = new HashSet<string>();

            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (var name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}