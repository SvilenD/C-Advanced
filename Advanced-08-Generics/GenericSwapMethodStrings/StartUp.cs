namespace GenericSwapMethodStrings
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var box = new Box<string>();

            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                box.Add(Console.ReadLine());
            }

            int[] swapIndexes = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int firstIndex = swapIndexes[0];
            int secondIndex = swapIndexes[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
