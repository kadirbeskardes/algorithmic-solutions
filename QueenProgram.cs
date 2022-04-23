namespace QueenProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] board = new int[8, 8];
            board[2, 0] = 1;
            board[1, 2] = 1;
            board[0, 4] = 1;
            board[3, 5] = 1;
            board[6, 3] = 1;
            board[7, 6] = 1;
            bool state;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] == 1)
                    {
                        Console.Write("Queen\t");
                        continue;
                    }
                    state = control(board, i, j);
                    if (state)
                    {
                        Console.Write("True\t");
                    }
                    else
                    {
                        Console.Write("False\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static bool control(int[,] board, int row, int col)
        {
            for (int i = 0; i < 8; i++)
            {
                if (board[row, i] == 1) return false;
            }
            for (int i = 0; i < 8; i++)
            {
                if (board[i, col] == 1) return false;
            }
            for (int i = row, j = col; i >= 0 && j<8; i--, j++)
            {
                if (board[i, j] == 1) return false;
            }
            for (int i = row, j = col; j >= 0 && i < 8; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }
            for (int i = row, j = col; j < 8 && i<8; i++, j++)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }

    }
}