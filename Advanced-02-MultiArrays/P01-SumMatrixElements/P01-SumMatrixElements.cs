namespace P01_SumMatrixElements
{
    using System;
    using System.Linq;
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            int[,] matrix = new int[rows, cols];

            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                    sum += currentRow[col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}