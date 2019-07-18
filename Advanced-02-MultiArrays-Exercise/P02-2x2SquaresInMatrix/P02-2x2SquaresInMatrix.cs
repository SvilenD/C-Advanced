namespace P02_2x2SquaresInMatrix
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var rowsCols = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var matrix = new string[rowsCols[0], rowsCols[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}