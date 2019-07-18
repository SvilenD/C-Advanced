using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ConnectedAreasInMatrix
{
    public class Area : IComparable<Area>
    {
        public Area(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
        public int Row { get; set; }

        public int Col { get; set; }

        public int Size { get; set; }

        public int CompareTo(Area other)
        {
            if (this.Size == other.Size)
            {
                if (this.Row == other.Row)
                {
                    return this.Col - other.Col;
                }
                return this.Row - other.Row;
            }

            return other.Size - this.Size;
        }
    }
    public class Program
    {
        private static int rows;
        private static int cols;

        public static void Main()
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());

            var matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            SortedSet<Area> areas = new SortedSet<Area>();

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] == '-')
                    {
                        Area area = new Area(r, c);
                        int size = 0;
                        FindAreaSize(matrix, r, c, ref size);
                        area.Size = size;
                        areas.Add(area);
                    }
                }
            }

            Console.WriteLine($"Total areas found: {areas.Count}");
            int index = 1;
            foreach (var area in areas)
            {
                Console.WriteLine($"Area{index} at ({area.Row}, {area.Col}), size: {area.Size}");
                index++;
            }

        }

        private static void FindAreaSize(char[][] matrix, int r, int c, ref int size)
        {
            if (IsInMatrixBoundaries(r, c) == false || matrix[r][c] == '*' || matrix[r][c] == 'X')
            {
                return;
            }

            size++;
            matrix[r][c] = 'X';
            FindAreaSize(matrix, r - 1, c, ref size);
            FindAreaSize(matrix, r, c - 1, ref size);
            FindAreaSize(matrix, r + 1, c, ref size);
            FindAreaSize(matrix, r, c + 1, ref size);
        }

        private static bool IsInMatrixBoundaries(int r, int c)
        {
            return r >= 0 && r < rows && c >= 0 && c < cols;
        }
    }
}