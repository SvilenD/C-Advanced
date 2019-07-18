namespace P07_KnightGame
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] board = new char[size][];

            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                board[row] = input;
            }

            int removedHorses = 0;
            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttacked = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (board[row][col] == 'K')
                        {
                            int attacked = CountAttacks(board, row, col);
                            if (attacked > maxAttacked)
                            {
                                maxAttacked = attacked;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }
                if (maxAttacked > 0)
                {
                    board[knightRow][knightCol] = '0';
                    removedHorses++;
                }
                else
                {
                    Console.WriteLine(removedHorses);
                    return;
                }
            }
        }

        private static int CountAttacks(char[][] board, int row, int col)
        {
            int count = 0;
            if (IsInBoard(row - 1, col - 2, board.Length) && board[row - 1][col - 2] == 'K') //1
            {
                count++;
            }
            if (IsInBoard(row - 1, col + 2, board.Length) && board[row - 1][col + 2] == 'K') //2
            {
                count++;
            }
            if (IsInBoard(row + 1, col - 2, board.Length) && board[row + 1][col - 2] == 'K') //3
            {
                count++;
            }
            if (IsInBoard(row + 1, col + 2, board.Length) && board[row + 1][col + 2] == 'K') //4
            {
                count++;
            }
            if (IsInBoard(row - 2, col - 1, board.Length) && board[row - 2][col - 1] == 'K') //5
            {
                count++;
            }
            if (IsInBoard(row - 2, col + 1, board.Length) && board[row - 2][col + 1] == 'K') //6
            {
                count++;
            }
            if (IsInBoard(row + 2, col - 1, board.Length) && board[row + 2][col - 1] == 'K') //7
            {
                count++;
            }
            if (IsInBoard(row + 2, col + 1, board.Length) && board[row + 2][col + 1] == 'K') //8
            {
                count++;
            }
            return count;
        }

        private static bool IsInBoard(int row, int col, int length)
        {
            return row >= 0 && row < length && col >= 0 && col < length;
        }
    }
}