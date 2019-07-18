namespace P02_TronRacers
{
    using System;
    using System.Linq;

    public class Program
    {
        static int size;
        static char[][] matrix;
        static int[] firstPlayerPsn = new int[2];
        static int[] secondPlayerPsn = new int[2];

        static void Main()
        {
            size = int.Parse(Console.ReadLine());

            matrix = new char[size][];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();

                if (matrix[row].Contains('f'))
                {
                    firstPlayerPsn[0] = row;
                    firstPlayerPsn[1] = Array.IndexOf(matrix[row], 'f');
                }

                if (matrix[row].Contains('s'))
                {
                    secondPlayerPsn[0] = row;
                    secondPlayerPsn[1] = Array.IndexOf(matrix[row], 's');
                }
            }

            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var firstDirection = commands[0].ToLower();
                var secondDirection = commands[1].ToLower();

                MovePlayer(firstDirection, 'f');
                MovePlayer(secondDirection, 's');
            }
        }

        private static void MovePlayer(string direction, char playerSymbol)
        {
            char enemySymbol;
            int[] initialPsn = null;

            if (playerSymbol == 'f')
            {
                enemySymbol = 's';
                initialPsn = firstPlayerPsn;
                MakeMovement(initialPsn, direction);
            }
            else
            {
                enemySymbol = 'f';
                initialPsn = secondPlayerPsn;
                MakeMovement(initialPsn, direction);
            }

            if (matrix[initialPsn[0]][initialPsn[1]] == enemySymbol)
            {
                matrix[initialPsn[0]][initialPsn[1]] = 'x';
                PrintResult();
            }

            matrix[initialPsn[0]][initialPsn[1]] = playerSymbol;
        }

        private static void MakeMovement(int[] initialPsn, string direction)
        {
            if (direction == "left")
            {
                if (initialPsn[1] == 0)
                {
                    initialPsn[1] = size - 1;
                }
                else
                {
                    initialPsn[1]--;
                }
            }
            else if (direction == "right")
            {
                if (initialPsn[1] == size - 1)
                {
                    initialPsn[1] = 0;
                }
                else
                {
                    initialPsn[1]++;
                }
            }
            else if (direction == "up")
            {
                if (initialPsn[0] == 0)
                {
                    initialPsn[0] = size - 1;
                }
                else
                {
                    initialPsn[0]--;
                }
            }
            else if (direction == "down")
            {
                if (initialPsn[0] == size - 1)
                {
                    initialPsn[0] = 0;
                }
                else
                {
                    initialPsn[0]++;
                }
            }
        }

        private static void PrintResult()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(matrix[row]);
            }

            Environment.Exit(0);
        }
    }
}