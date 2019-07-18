using System;
using System.Linq;

namespace P03_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int sum = 0;
            for (int row = 0, col = 0; row < size; row++, col++)
            {
                sum += matrix[row, col];
            }
            Console.WriteLine(sum);
        }
    }
}