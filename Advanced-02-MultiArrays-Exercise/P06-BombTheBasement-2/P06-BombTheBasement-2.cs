namespace P06_BombTheBasement_2
{
using System;
using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split()
                   .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[][] basement = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                basement[row] = new int[cols];
            }

            int[] bomb = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
            int bombRow = bomb[0];
            int bombCol = bomb[1];
            int bombRadius = bomb[2];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double radius = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));
                    if (radius <= bombRadius)
                    {
                        basement[row][col] = 1;
                    }
                }
            }

            int[][] rotated = new int[cols][]; //правим завъртяна матрица, редове = колоните на оригинала и колоните = редовете на оригинала
            for (int row = 0; row < cols; row++)
            {
                rotated[row] = new int[rows];
                for (int col = 0; col < rows; col++)
                {
                    rotated[row][col] = basement[col][row];
                }
                rotated[row] = rotated[row].OrderByDescending(x => x).ToArray(); // подреждаме 1-ците да са в края
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    basement[row][col] = rotated[col][row]; //презаписваме стойностите в оригинала
                }
            }

            foreach (var row in basement)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}