namespace ThroneConquering
{
    using System;
    using System.Linq;

    public class HelensAbduction
    {
        static int parisEnergy;
        static int fieldRows;
        static char[][] field;
        static bool parisFoundHelen = false;

        public static void Main()
        {
            parisEnergy = int.Parse(Console.ReadLine());
            fieldRows = int.Parse(Console.ReadLine());

            field = new char[fieldRows][];

            int[] helenPsn = new int[2];
            int[] parisPsn = new int[2];

            for (int row = 0; row < fieldRows; row++)
            {
                field[row] = Console.ReadLine().ToCharArray();

                if (field[row].Contains('H'))
                {
                    helenPsn[0] = row;
                    helenPsn[1] = Array.IndexOf(field[row], 'H');
                }

                if (field[row].Contains('P'))
                {
                    parisPsn[0] = row;
                    parisPsn[1] = Array.IndexOf(field[row], 'P');
                }
            }

            while (parisFoundHelen == false && parisEnergy > 0)
            {
                var command = Console.ReadLine().Split();

                int enemyRow = int.Parse(command[1]);
                int enemyCol = int.Parse(command[2]);
                field[enemyRow][enemyCol] = 'S';

                parisEnergy--;
                MoveParis(parisPsn, command[0]);

                if ((parisPsn[0] == helenPsn[0] && parisPsn[1] == helenPsn[1]))
                {
                    field[parisPsn[0]][parisPsn[1]] = '-';
                    parisFoundHelen = true;
                }
            }

            if (parisFoundHelen)
            {
                Console.WriteLine($"Paris has successfully sat on the throne! Energy left: {parisEnergy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisPsn[0]};{parisPsn[1]}.");
            }

            for (int row = 0; row < fieldRows; row++)
            {
                Console.WriteLine($"{string.Join("", field[row])}");
            }
        }

        private static void MoveParis(int[] parisPsn, string direction)
        {
            if (direction == "up" && parisPsn[0] > 0)
            {
                field[parisPsn[0]][parisPsn[1]] = '-';
                parisPsn[0]--;
            }
            else if (direction == "down" && parisPsn[0] < fieldRows - 1)
            {
                field[parisPsn[0]][parisPsn[1]] = '-';
                parisPsn[0]++;
            }
            else if (direction == "left" && parisPsn[1] > 0)
            {
                field[parisPsn[0]][parisPsn[1]] = '-';
                parisPsn[1]--;
            }
            else if (direction == "right" && parisPsn[0] < field[0].Length - 1)
            {
                field[parisPsn[0]][parisPsn[1]] = '-';
                parisPsn[1]++;
            }

            if (field[parisPsn[0]][parisPsn[1]] == 'S')
            {
                parisEnergy -= 2;
            }
            if (parisEnergy <= 0)
            {
                field[parisPsn[0]][parisPsn[1]] = 'X';
            }
            else
            {
                field[parisPsn[0]][parisPsn[1]] = 'P';
            }
        }
    }
}