namespace SpaceStationEstablishment
{
    using System;
    using System.Linq;

    public class StartUp
    {
        private static char[][] matrix;
        private static int size;
        private static int playerRow;
        private static int playerCol;
        private static int power;
        private static bool isAlive = true;

        public static void Main()
        {
            size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
                if (matrix[row].Contains('S'))
                {
                    playerRow = row;
                    playerCol = Array.IndexOf(matrix[row], 'S');
                }
            }

            while (isAlive && power < 50)
            {
                var command = Console.ReadLine();
                MovePlayer(command);
            }
        }

        private static void MovePlayer(string command)
        {
            matrix[playerRow][playerCol] = '-';

            if (command == "up")
            {
                playerRow--;
            }
            else if (command == "down")
            {
                playerRow++;
            }
            else if (command == "left")
            {
                playerCol--;
            }
            else if (command == "right")
            {
                playerCol++;
            }

            if (IsInMatrix() == false)
            {
                isAlive = false;
                PrinResult();
            }
            else if (matrix[playerRow][playerCol] == 'O')
            {
                matrix[playerRow][playerCol] = '-';
                for (int row = 0; row < size; row++)
                {
                    if (matrix[row].Contains('O'))
                    {
                        playerRow = row;
                        playerCol = Array.IndexOf(matrix[row], 'O');
                        matrix[playerRow][playerCol] = '-';
                    }
                }
            }
            else if (char.IsDigit(matrix[playerRow][playerCol]))
            {
                power += int.Parse(matrix[playerRow][playerCol].ToString());
                matrix[playerRow][playerCol] = 'S';
                if (power >= 50)
                {
                    PrinResult();
                }
            }
        }

        private static bool IsInMatrix()
        {
            if (playerRow >= 0 && playerRow < size && playerCol >= 0 && playerCol < size)
            {
                return true;
            }

            return false;
        }

        private static void PrinResult()
        {
            if (isAlive == false)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {power}");

            for (int row = 0; row < size; row++)
            {
                Console.WriteLine($"{string.Join(string.Empty, matrix[row])}");
            }
        }
    }
}