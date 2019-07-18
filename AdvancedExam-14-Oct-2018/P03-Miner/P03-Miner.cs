namespace P03_Miner
{
    using System;
    using System.Linq;

    class Program
    {
        static int size;
        static char[][] matrix;
        static int[] playerPsn = new int[2];
        static bool lostGame = false;
        static int coalsCount = 0;
        static void Main()
        {
            size = int.Parse(Console.ReadLine());
            matrix = new char[size][];
            var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            FillMatrix();
            MovePlayer(commands);

            if (lostGame)
            {
                Console.WriteLine($"Game over! ({playerPsn[0]}, {playerPsn[1]})");
            }
            else if (coalsCount == 0)
            {
                Console.WriteLine($"You collected all coals! ({playerPsn[0]}, {playerPsn[1]})");
            }
            else
            {
                Console.WriteLine($"{coalsCount} coals left. ({playerPsn[0]}, {playerPsn[1]})");
            }
        }


        private static void FillMatrix()
        {
            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                if (matrix[row].Contains('s'))
                {
                    playerPsn[0] = row;
                    playerPsn[1] = Array.IndexOf(matrix[row], 's');
                }
                if (matrix[row].Contains('c'))
                {
                    coalsCount += matrix[row].Count(c => c == 'c');
                }
            }
        }

        private static void MovePlayer(string[] commands)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up" && playerPsn[0] > 0)
                {
                    playerPsn[0]--;
                }
                else if (commands[i] == "down" && playerPsn[0] < matrix.GetLength(0) - 1)
                {
                    playerPsn[0]++;
                }
                else if (commands[i] == "left" && playerPsn[1] > 0)
                {
                    playerPsn[1]--;
                }
                else if (commands[i] == "right" && playerPsn[1] < matrix.GetLength(0) - 1)
                {
                    playerPsn[1]++;
                }

                if (matrix[playerPsn[0]][playerPsn[1]] == 'e')
                {
                    lostGame = true;
                    return;
                }

                else if (matrix[playerPsn[0]][playerPsn[1]] == 'c')
                {
                    coalsCount--;
                    matrix[playerPsn[0]][playerPsn[1]] = '*';
                    if (coalsCount == 0)
                    {
                        return;
                    }
                }
            }
        }
    }
}