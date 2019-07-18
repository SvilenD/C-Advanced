namespace P09_Miner
{
    using System;
    using System.Linq;

    public class Program
    {
        static int coalsCollected = 0;
        static int[] position = new int[2];
        static bool gameOver = false;

        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            char[][] field = new char[size][];
            int totalCoals = 0;
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                field[row] = line;
                totalCoals += line.Count(x => x == 'c');
                if (line.Contains('s'))
                {
                    position[0] = row;
                    for (int index = 0; index < line.Length; index++)
                    {
                        if (line[index] == 's')
                        {
                            position[1] = index;
                        }
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up" && position[0] > 0)
                {
                    position[0]--;
                    MoveTheMiner(field);
                }
                else if (commands[i] == "down" && position[0] < field.Length - 1)
                {
                    position[0]++;
                    MoveTheMiner(field);
                }
                else if (commands[i] == "left" && position[1] > 0)
                {
                    position[1]--;
                    MoveTheMiner(field);
                }
                else if (commands[i] == "right" && position[1] < size - 1)
                {
                    position[1]++;
                    MoveTheMiner(field);
                }
                if (gameOver == true)
                {
                    Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                    return;
                }
                else if (totalCoals == coalsCollected)
                {
                    Console.WriteLine($"You collected all coals! ({position[0]}, {position[1]})");
                    return;
                }
            }
            Console.WriteLine($"{totalCoals - coalsCollected} coals left. ({position[0]}, {position[1]})");
        }

        private static void MoveTheMiner(char[][] field)
        {
            if (field[position[0]][position[1]] == 'c')
            {
                coalsCollected++;
                field[position[0]][position[1]] = '*';
            }
            else if (field[position[0]][position[1]] == 'e')
            {
                gameOver = true;
            }
        }
    }
}