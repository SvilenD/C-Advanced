using System;
using System.Linq;

namespace P05_SquareMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = 0;
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[startRow, startCol]} {matrix[startRow, startCol + 1]}");
            Console.WriteLine($"{matrix[startRow + 1, startCol]} {matrix[startRow + 1, startCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}