namespace Sneaking
{
    using System;
    using System.Linq;

    public class Program
    {
        public static char[][] matrix;
        public static int samRow;
        public static int samCol;
        public static int nikoladzeRow;
        public static int nikoladzeCol;

        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            matrix = new char[rows][];
            GetMatrix();

            string commands = Console.ReadLine();

            for (int i = 0; i < commands.Length; i++)
            {
                EnemyMovement();

                if (IsGameLost())
                {
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    break;
                }

                if (commands[i] != 'W')
                {
                    MovePlayer(commands[i]); 
                }

                if (samRow == nikoladzeRow)
                {
                    matrix[nikoladzeRow][nikoladzeCol] = 'X';
                    Console.WriteLine($"Nikoladze killed!");
                    break;
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
        }

        private static void MovePlayer(char direction)
        {
            matrix[samRow][samCol] = '.';

            if (direction == 'U')
            {
                samRow--;
            }
            else if (direction == 'D')
            {
                samRow++;
            }
            else if (direction == 'L')
            {
                samCol--;
            }
            else if (direction == 'R')
            {
                samCol++;
            }

            matrix[samRow][samCol] = 'S';
        }

        private static void EnemyMovement()
        {
            for (var row = 0; row < matrix.Length; row++)
            {
                for (var col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'b')
                    {
                        if (col == matrix[row].Length - 1)
                        {
                            matrix[row][col] = 'd';
                        }
                        else
                        {
                            matrix[row][col + 1] = 'b';
                            matrix[row][col] = '.';
                        }

                        break;
                    }

                    if (matrix[row][col] == 'd')
                    {
                        if (col == 0)
                        {
                            matrix[row][col] = 'b';
                        }
                        else
                        {
                            matrix[row][col - 1] = 'd';
                            matrix[row][col] = '.';
                        }

                        break;
                    }
                }
            }
        }

        private static bool IsGameLost()
        {
            if ((matrix[samRow].Contains('b') && Array.IndexOf(matrix[samRow], 'b') < samCol)
              || (matrix[samRow].Contains('d') && Array.IndexOf(matrix[samRow], 'd') > samCol))
            {
                matrix[samRow][samCol] = 'X';
                return true;
            }

            return false;
        }

        private static void GetMatrix()
        {
            for (var row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();

                for (var col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'S')
                    {
                        samRow = row;
                        samCol = col;
                        matrix[row][col] = '.';
                    }
                    if (matrix[row][col] == 'N')
                    {
                        nikoladzeRow = row;
                        nikoladzeCol = col;
                    }
                }
            }
        }
    }
}