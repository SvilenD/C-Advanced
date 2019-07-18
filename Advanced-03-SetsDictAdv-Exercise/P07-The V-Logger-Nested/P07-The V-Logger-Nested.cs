namespace P07_The_V_Logger_Nested
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var vLoggersData = new Dictionary<string, Dictionary<string, HashSet<string>>>(); //user -> "followers" - names
                                                                                              //user -> "following" - names
            while (true)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Statistics")
                {
                    break;
                }
                else if (input[1] == "followed" && vLoggersData.ContainsKey(input[0]) && vLoggersData.ContainsKey(input[2]))
                {
                    if (input[0] == input[2])
                    {
                        continue;
                    }
                    string follower = input[0];
                    string user = input[2];
                    vLoggersData[follower]["following"].Add(user);
                    vLoggersData[user]["followers"].Add(follower);
                }
                else if (input[1] == "joined" && vLoggersData.ContainsKey(input[0]) == false)
                {
                    string user = input[0];
                    vLoggersData.Add(user, new Dictionary<string, HashSet<string>>());
                    vLoggersData[user].Add("following", new HashSet<string>());
                    vLoggersData[user].Add("followers", new HashSet<string>());
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vLoggersData.Count} vloggers in its logs.");

            var sortedVloggers = vLoggersData.OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count).ToDictionary(k => k.Key, v => v.Value);
            int index = 1;
            foreach (var (user, value) in sortedVloggers)
            {
                int followersCount = sortedVloggers[user]["followers"].Count;
                int followingCount = sortedVloggers[user]["following"].Count;

                Console.WriteLine($"{index}. {user} : {followersCount} followers, {followingCount} following");

                if (index == 1)
                { 
                    foreach (var item in value["followers"].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                index++;
            }
        }
    }
}