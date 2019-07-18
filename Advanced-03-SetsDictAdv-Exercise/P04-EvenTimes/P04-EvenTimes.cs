namespace P04_EvenTimes
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<int> nums = new HashSet<int>();
            int length = int.Parse(Console.ReadLine());

            int even = 0;
            for (int i = 0; i < length; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (nums.Contains(num) == false)
                {
                    nums.Add(num);
                }
                else
                {
                    nums.Remove(num);
                    even = num;
                }
            }
            Console.WriteLine(even);
        }
    }
}