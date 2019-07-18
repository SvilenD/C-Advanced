namespace P04_MatrixShuffling
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

            var rows = dimensions[0];
            var cols = dimensions[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0].ToLower() == "end")
                {
                    break;
                }
                else if (command[0] == "swap" && command.Length == 5)
                {
                    int x1 = int.Parse(command[1]);
                    int y1 = int.Parse(command[2]);
                    int x2 = int.Parse(command[3]);
                    int y2 = int.Parse(command[4]);
                    if (x1 >= 0 && x1 < rows && x2 >= 0 && x2 < rows &&
                        y1 >= 0 && y1 < cols && y2 >= 0 && y2 < cols)
                    {
                        string temp = matrix[x2, y2];
                        matrix[x2, y2] = matrix[x1, y1];
                        matrix[x1, y1] = temp;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col]);
                                if (col < cols - 1)
                                {
                                    Console.Write(' ');
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}