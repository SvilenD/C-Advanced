namespace P01_DiagonalDifference
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int primary = 0;
            for (int row = 0, col = 0; col < size; row++, col++)
            {
                primary += matrix[row, col];
            }
            int secondary = 0;
            for (int row = size - 1, col = 0; row >= 0; row--, col++)
            {
                secondary += matrix[row, col];
            }
            Console.WriteLine($"{Math.Abs(primary - secondary)}");
        }
    }
}