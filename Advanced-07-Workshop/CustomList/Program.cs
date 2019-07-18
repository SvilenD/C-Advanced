namespace CustomList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var customList = new CustomList<int>();

            customList.Add(3);
            customList.Add(3);
            customList.Add(31);
            customList.Add(3);
            customList.Add(3333);
            customList.Add(33);
            Console.WriteLine(customList[0]);
            customList[5] = 5;
            Console.WriteLine($"List count is {customList.Count}.");
            customList.RemoveAt(9);
            customList.RemoveAt(4);
            customList.RemoveAt(3);
            customList.RemoveAt(2);
            //customList.RemoveAt(1);
            customList.Shrink();
            //Console.WriteLine(customList[4]);
            Console.WriteLine(customList.Contains(31));
            Console.WriteLine($"List count is {customList.Count}.");
        }
    }
}
