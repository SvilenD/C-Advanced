using System;
using System.Linq;

namespace P06_JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArrray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] current = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                jaggedArrray[row] = current;
            }

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                if (row >= 0 && row < jaggedArrray.GetLength(0) && col >= 0 && col < jaggedArrray[row].Length)
                {
                    if (input[0] == "Add")
                    {
                        jaggedArrray[row][col] += value;
                    }
                    else if (input[0] == "Subtract")
                    {
                        jaggedArrray[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            foreach (var row in jaggedArrray)
            {
                Console.WriteLine($"{string.Join(" ", row)}");
            }
        }
    }
}