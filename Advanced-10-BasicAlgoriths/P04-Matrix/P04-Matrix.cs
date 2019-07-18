namespace P04_Matrix
{
    using System;
    using System.Linq;

    public class Program
    {
        private static int rows;
        private static int cols;
        public static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            rows = matrixSize[0];
            cols = matrixSize[1];

            var matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
            }

            char fillChar = char.Parse(Console.ReadLine());
            int[] start = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int startRow = start[0];
            int startCol = start[1];

            char charToReplace = matrix[startRow][startCol];
            ReplaceMatrixSymbols(matrix, fillChar, charToReplace, startRow, startCol);

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void ReplaceMatrixSymbols(char[][] matrix, char newSymbol, char charToReplace, int r, int c)
        {
            if (IsInMatrixBoundaries(r, c) == false || matrix[r][c] == newSymbol || matrix[r][c] != charToReplace)
            {
                return;
            }

            matrix[r][c] = newSymbol;

            ReplaceMatrixSymbols(matrix, newSymbol, charToReplace, r - 1, c);
            ReplaceMatrixSymbols(matrix, newSymbol, charToReplace, r + 1, c);
            ReplaceMatrixSymbols(matrix, newSymbol, charToReplace, r, c - 1);
            ReplaceMatrixSymbols(matrix, newSymbol, charToReplace, r, c + 1);
        }

        private static bool IsInMatrixBoundaries(int r, int c)
        {
            return r >= 0 && r < rows && c >= 0 && c < cols;
        }
    }
}