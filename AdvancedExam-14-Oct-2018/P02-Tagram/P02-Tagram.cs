namespace P02_Tagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine().Split(" -> ");
                if (input[0].ToLower() == "end")
                {
                    break;
                }
                else if (input[0].StartsWith("ban"))
                {
                    var splitted = input[0].Split();
                    var userToRemove = splitted[1];
                    data.Remove(userToRemove);
                }
                else
                {
                    var user = input[0];
                    var tag = input[1];
                    var likes = int.Parse(input[2]);

                    if (data.ContainsKey(user) == false)
                    {
                        data.Add(user, new Dictionary<string, int>());
                    }
                    if (data[user].ContainsKey(tag) == false)
                    {
                        data[user].Add(tag, 0);
                    }
                    data[user][tag] += likes;
                }
            }

            foreach (var user in data.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine(user.Key);
                foreach (var kvp in user.Value)
                {
                    Console.WriteLine($"- {kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}