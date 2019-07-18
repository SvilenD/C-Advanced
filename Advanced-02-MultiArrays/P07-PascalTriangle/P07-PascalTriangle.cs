namespace P07_PascalTriangle
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var pascal = new ulong[rows][];
            pascal[0] = new ulong[] { 1 };

            for (int row = 1; row < rows; row++)
            {
                int length = pascal[row - 1].Length + 1;
                pascal[row] = new ulong[length];
                pascal[row][0] = 1;
                pascal[row][length - 1] = 1;
                for (int col = 1; col < length - 1; col++)
                {
                    pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
                }
            }
            foreach (var row in pascal)
            {
                Console.WriteLine($"{string.Join(" ", row)}");
            }
        }
    }
}