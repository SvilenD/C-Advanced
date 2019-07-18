namespace P02_ExcelFunctions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(", ");
            }

            var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();
            if (command[0] == "hide")
            {
                result = HideColumn(command[1], matrix);
            }
            else if (command[0] == "sort")
            {
                var param = command[1];
                result = SortMatrix(param, matrix);
            }
            else if (command[0] == "filter")
            {
                string param = command[1];
                string value = command[2];
                result = FilterLines(param, value, matrix);
            }

            Console.WriteLine(result.ToString().Trim());
        }

        private static StringBuilder FilterLines(string param, string value, string[][] matrix)
        {
            int index = Array.IndexOf(matrix[0], param);

            StringBuilder result = new StringBuilder();
            result.Append(string.Join(" | ", matrix[0]));

            for (int row = 1; row < matrix.Length; row++)
            {
                if (matrix[row][index] == value)
                {
                    result.AppendLine();
                    result.Append($"{string.Join(" | ", matrix[row])}");
                }
            }
            return result;
        }

        private static StringBuilder SortMatrix(string param, string[][] matrix)
        {
            StringBuilder result = new StringBuilder();
            int index = 0;
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[0][col] == param)
                {
                    index = col;
                }
            }

            result.AppendLine(string.Join(" | ", matrix[0]));

            foreach (var row in matrix.Skip(1).OrderBy(r => r[index]))
            {
                result.AppendLine($"{string.Join(" | ", row)}");
            }
            return result;
        }

        private static StringBuilder HideColumn(string filter, string[][] matrix)
        {
            int index = Array.IndexOf(matrix[0], filter);

            StringBuilder result = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)         
            {
                var linesToPrint = new List<string>();
                linesToPrint.AddRange(matrix[row].Take(index));
                linesToPrint.AddRange(matrix[row].Skip(index + 1));
                result.AppendLine(string.Join(" | ", linesToPrint));
                // result.AppendLine(string.Join(" | ", matrix[row].Where((x, i) => i != index))); //
            }
            return result;
        }
    }
}