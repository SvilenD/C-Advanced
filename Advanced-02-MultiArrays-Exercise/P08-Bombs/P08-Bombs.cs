namespace P08_Bombs
{
    using System;
    using System.Linq;

    public class Bombs
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                matrix[row] = input;
            }

            var bombs = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < bombs.Length; i += 2)
            {
                int bombRow = bombs[i];
                int bombCol = bombs[i + 1];

                if (matrix[bombRow][bombCol] > 0)
                {
                    int bombPower = matrix[bombRow][bombCol];
                    matrix[bombRow][bombCol] = 0;

                    for (int row = bombRow - 1; row <= bombRow + 1; row++)
                    {
                        for (int col = bombCol - 1; col <= bombCol + 1; col++)
                        {
                            if (row >= 0 && row < matrix.Length && col >= 0 && col < size)
                            {
                                if (matrix[row][col] > 0)
                                {
                                    matrix[row][col] -= bombPower;
                                }
                            }
                        }
                    }
                }
            }

            int alive = 0;
            int sum = 0;
            foreach (var row in matrix)
            {
                alive += row.Count(x => x > 0);
                sum += row.Where(x => x > 0).Sum();
            }

            Console.WriteLine($"Alive cells: {alive}");
            Console.WriteLine($"Sum: {sum}");
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}