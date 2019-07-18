namespace P03_Bombs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static int[][] matrix;
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string[] bombs = Console.ReadLine().Split();
            Queue<string> coordinates = new Queue<string>(bombs);

            DetonateBombs(coordinates);

            PrintResult();
        }


        private static void DetonateBombs(Queue<string> coordinates)
        {
            while (coordinates.Count > 0)
            {
                int[] input = coordinates.Dequeue().Split(',').Select(int.Parse).ToArray();
                int bombRow = input[0];
                int bombCol = input[1];

                if (matrix[bombRow][bombCol] > 0)
                {
                    int bombPower = matrix[bombRow][bombCol];
                    matrix[bombRow][bombCol] = 0;

                    for (int row = bombRow - 1; row <= bombRow + 1; row++)
                    {
                        for (int col = bombCol - 1; col <= bombCol + 1; col++)
                        {
                            if (IsToExplode(row, col))
                            {
                                matrix[row][col] -= bombPower;
                            }
                        }
                    }
                }
            }
        }

        private static bool IsToExplode(int r, int c)
        {
            return r >= 0 && r < matrix.Length && c >= 0 && c < matrix[r].Length && matrix[r][c] > 0;
        }

        private static void PrintResult()
        {
            int alive = 0;
            long sum = 0;

            foreach (var row in matrix)
            {
                alive += row.Count(x => x > 0);
                sum += row.Where(x => x > 0).Sum();
            }

            Console.WriteLine($"Alive cells: {alive}");
            Console.WriteLine($"Sum: {sum}");

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}