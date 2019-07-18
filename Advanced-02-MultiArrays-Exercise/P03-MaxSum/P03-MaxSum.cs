namespace P03_MaxSum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];

            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            long maxSum = long.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum += matrix[row + i, col + j];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    Console.Write(matrix[row, col]);
                    if (col < cols - 1)
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}