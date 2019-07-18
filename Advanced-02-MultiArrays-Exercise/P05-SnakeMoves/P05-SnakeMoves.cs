namespace P05_SnakeMoves
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            int length = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (length == snake.Length)
                    {
                        length = 0;
                    }
                    matrix[row, col] = snake[length];
                    length++;
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}