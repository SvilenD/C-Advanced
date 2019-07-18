namespace P06_BombTheBasement
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] basement = new int[rows, cols];

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombRow = bomb[0];
            int bombCol = bomb[1];
            int bombRadius = bomb[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double radius = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));
                    if (radius <= bombRadius)
                    {
                        basement[row, col] = 1;
                    }
                }
            }

            for (int row = rows - 1; row >= 1; row--)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (basement[row, col] == 1)
                    {
                        for (int upperRow = 0; upperRow < row; upperRow++)
                        {
                            if (basement[upperRow, col] == 0)
                            {
                                basement[upperRow, col] = 1;
                                basement[row - upperRow, col] = 0;
                            }
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(basement[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}