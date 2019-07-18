using System;
using System.Linq;

namespace P02_SumMatrixCols
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}