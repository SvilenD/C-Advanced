using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[][] matrix = new char[rows][];

            char[] snakeInput = Console.ReadLine().ToCharArray();
            Queue<char> snake = new Queue<char>(snakeInput);

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = snake.Peek();
                    snake.Enqueue(snake.Dequeue());
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}