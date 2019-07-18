namespace P07_SoftUniParty_SortedSet
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            SortedSet<string> guests = new SortedSet<string>();

            while (true)
            {
                var entry = Console.ReadLine();
                if (entry?.ToLower() == "party")
                {
                    break;
                }

                guests.Add(entry);
            }

            while (true)
            {
                var entry = Console.ReadLine();
                if (entry?.ToLower() == "end")
                {
                    break;
                }

                guests.Remove(entry);
            }
        }
    }
}
