namespace P10_RadioactiveMutantVampireBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RadioactiveMutantVampireBunnies
    {
        static int[] position = new int[2];
        static bool gameOver = false;
        static bool winGame = false;

        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                matrix[row] = line.ToCharArray();
                if (line.Contains('P'))
                {
                    position[0] = row;
                    for (int index = 0; index < line.Length; index++)
                    {
                        if (line[index] == 'P')
                        {
                            position[1] = index;
                        }
                    }
                }
            }

            string commands = Console.ReadLine();

            for (int i = 0; i < commands.Length; i++)
            {
                MovePlayer(commands[i], matrix);
                ExpandBunnies(matrix);
                if (winGame || gameOver)
                {
                    break;
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }

            if (winGame)
            {
                Console.Write("won: ");
            }
            else
            {
                Console.Write("dead: ");
            }
            Console.WriteLine($"{ position[0]} {position[1]}");
        }

        private static void MovePlayer(char direction, char[][] matrix)
        {
            matrix[position[0]][position[1]] = '.';
            if (direction == 'U')
            {
                position[0]--;
            }
            else if (direction == 'D')
            {
                position[0]++;
            }
            else if (direction == 'L')
            {
                position[1]--;
            }
            else if (direction == 'R')
            {
                position[1]++;
            }

            if (position[0] < 0 || position[1] < 0 || position[0] == matrix.Length || position[1] == matrix[position[0]].Length)
            {
                winGame = true;
                if (direction == 'U')
                {
                    position[0]++;
                }
                else if (direction == 'D')
                {
                    position[0]--;
                }
                else if (direction == 'L')
                {
                    position[1]++;
                }
                else if (direction == 'R')
                {
                    position[1]--;
                }
            }
            else if (matrix[position[0]][position[1]] == 'B')
            {
                gameOver = true;
            }
            else
            {
                matrix[position[0]][position[1]] = 'P';
            }
        }

        private static void ExpandBunnies(char[][] matrix)
        {
            var newBunnies = new List<int[]>();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'B')
                    {
                        if (row > 0)
                        {
                            newBunnies.Add(new int[] { row - 1, col });
                        }
                        if (col > 0)
                        {
                            newBunnies.Add(new int[] { row, col - 1 });
                        }
                        if (row < matrix.Length - 1)
                        {
                            newBunnies.Add(new int[] { row + 1, col }); ;
                        }
                        if (col < matrix[row].Length - 1)
                        {
                            newBunnies.Add(new int[] { row, col + 1 });
                        }
                    }
                }
            }

            foreach (var item in newBunnies)
            {
                matrix[item[0]][item[1]] = 'B';
            }
            if (matrix.All(x => x.All(y => y != 'P')))
            {
                gameOver = true;
            }
        }
    }
}