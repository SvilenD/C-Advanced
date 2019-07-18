using System;

namespace P04_SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char symbol = currentRow[col];
                    matrix[row, col] = symbol;
                }
            }
            char symbolToFind = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == symbolToFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbolToFind} does not occur in the matrix");
        }
    }
}