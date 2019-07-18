namespace P08_Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var contestPass = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(':');
                if (input[0] == "end of contests")
                {
                    break;
                }
                string contest = input[0];
                string pass = input[1];
                if (contestPass.ContainsKey(contest) == false)
                {
                    contestPass.Add(contest, pass);
                }
            }

            var usersContestPoints = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of submissions")
                {
                    break;
                }

                string contest = input[0];
                string pass = input[1];
                if (contestPass.ContainsKey(contest))
                {
                    if (contestPass[contest] == pass)
                    {
                        string user = input[2];
                        int points = int.Parse(input[3]);
                        if (usersContestPoints.ContainsKey(user) == false)
                        {
                            usersContestPoints.Add(user, new Dictionary<string, int>());
                            usersContestPoints[user].Add(contest, points);
                        }
                        else if (usersContestPoints[user].ContainsKey(contest) == false)
                        {
                            usersContestPoints[user].Add(contest, points);
                        }
                        else if (usersContestPoints[user][contest] < points)
                        {
                            usersContestPoints[user][contest] = points;
                        }
                    }
                }
            }

            var maxTotal = usersContestPoints.Values.Max(x => x.Values.Sum());
            string bestUser = usersContestPoints.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault().Key;
            //usersContestPoints.FirstOrDefault(x => x.Value.Values.Sum() == maxTotal).Key;

            //foreach (var user in usersContestPoints)
            //{
            //    int total = user.Value.Values.Sum();
            //    if (total > maxTotal)
            //    {
            //        maxTotal = total;
            //        bestUser = user.Key;
            //    }
            //}
            Console.WriteLine($"Best candidate is {bestUser} with total {maxTotal} points.");
            Console.WriteLine("Ranking: ");
            foreach (var user in usersContestPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var kvp in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}