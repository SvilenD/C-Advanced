namespace P07_SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                else if (char.IsDigit(input[0]))
                {
                    VIP.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else if (VIP.Contains(input))
                {
                    VIP.Remove(input);
                }
                else if (regular.Contains(input))
                {
                    regular.Remove(input);
                }
            }

            Console.WriteLine(VIP.Count + regular.Count);

            foreach (var guest in VIP)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}