namespace TheGarden
{
    using System;

    public class Program
    {
        static char[][] garden;
        static int lettuceCount = 0;
        static int potatoesCount = 0;
        static int carrotsCount = 0;
        static int harmedVegsCount = 0;

        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            garden = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                garden[row] = Console.ReadLine()
                    .ToUpper()
                    .Replace(" ", string.Empty)
                    .ToCharArray();
            }

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0].ToLower() == "end")
                {
                    break;
                }

                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);

                if (row >= 0 && row < rows && col >= 0 && col < garden[row].Length)
                {
                    if (input[0] == "Harvest")
                    {
                        Harverst(row, col);
                    }
                    else if (input[0] == "Mole")
                    {
                        string direction = input[3];
                        moleHarms(row, col, direction);
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine($"{string.Join(' ', garden[row]).Trim()}");
            }

            Console.WriteLine($"Carrots: {carrotsCount}");
            Console.WriteLine($"Potatoes: {potatoesCount}");
            Console.WriteLine($"Lettuce: {lettuceCount}");
            Console.WriteLine($"Harmed vegetables: {harmedVegsCount}");
        }

        private static void moleHarms(int startRow, int startCol, string direction)
        {
            if (direction == "up")
            {
                for (int row = startRow; row >= 0; row -= 2)
                {
                    if (garden[row][startCol] != ' ')
                    {
                        harmedVegsCount++;
                        garden[row][startCol] = ' ';
                    }
                }
            }
            else if (direction == "down")
            {
                for (int row = startRow; row < garden.Length; row += 2)
                {
                    if (garden[row][startCol] != ' ')
                    {
                        harmedVegsCount++;
                        garden[row][startCol] = ' ';
                    }
                }
            }
            else if (direction == "left")
            {
                for (int col = startCol; col >= 0; col -= 2)
                {
                    if (garden[startRow][col] != ' ')
                    {
                        harmedVegsCount++;
                        garden[startRow][col] = ' ';
                    }
                }
            }
            else if (direction == "right")
            {
                for (int col = startCol; col < garden[startRow].Length; col += 2)
                {
                    if (garden[startRow][col] != ' ')
                    {
                        harmedVegsCount++;
                        garden[startRow][col] = ' ';
                    }
                }
            }
        }

        private static void Harverst(int row, int col)
        {
            var vegetable = garden[row][col];
            if (vegetable == 'C')
            {
                carrotsCount++;
            }
            else if (vegetable == 'L')
            {
                lettuceCount++;
            }
            else if (vegetable == 'P')
            {
                potatoesCount++;
            }
            garden[row][col] = ' ';
        }
    }
}