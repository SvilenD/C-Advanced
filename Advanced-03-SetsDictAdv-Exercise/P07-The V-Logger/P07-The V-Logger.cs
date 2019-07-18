namespace P07_The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var vLoggersData = new Dictionary<string, HashSet<string>>(); //user - > followersNames
            var followingData = new Dictionary<string, int[]>(); // user -> [0]followedBy, [1]following

            while (true)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Statistics")
                {
                    break;
                }
                else if (input[1] == "followed" && vLoggersData.ContainsKey(input[0]) && vLoggersData.ContainsKey(input[2]))
                {
                    if (input[0] != input[2] && vLoggersData[input[2]].Contains(input[0]) == false)
                    {
                        var user = input[2];
                        var follower = input[0];
                        vLoggersData[input[2]].Add(follower);
                        followingData[user][0]++;       //increase people that follow user
                        followingData[follower][1]++;   // increase people that follower follows
                    }
                }
                else if (input[1] == "joined" && vLoggersData.ContainsKey(input[0]) == false)
                {
                    vLoggersData.Add(input[0], new HashSet<string>());
                    followingData.Add(input[0], new int[2]);
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vLoggersData.Count} vloggers in its logs.");
            int index = 1;

            foreach (var user in followingData.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]))
            {
                var vLogger = user.Key;
                var followers = user.Value[0];
                int followingCount = user.Value[1]; //vLoggers.Count((x => x.Value.Contains(vlogger)));
                Console.WriteLine($"{index}. {vLogger} : {followers} followers, {followingCount} following");
                if (index == 1)
                {
                    foreach (var kvp in vLoggersData[vLogger].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {kvp}");
                    }
                }
                index++;
            }
        }
    }
}