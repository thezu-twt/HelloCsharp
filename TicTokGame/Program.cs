using System;

namespace TicTokGame
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = { {' ', ' ', ' '},
                              {' ', ' ', ' '},
                              {' ', ' ', ' '} };
            Random random = new Random();
            //設置每個位置是否為空值
            bool hasVacancies = false;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (board[i, j] == ' ') 
                    {
                        hasVacancies = true;
                        break;
                    }
                }
            }
            do
            {
                //顯示棋盤
                Console.WriteLine("    0   1   2 ");
                Console.WriteLine("              ");
                Console.WriteLine("0   {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("   ---+---+---");
                Console.WriteLine("1   {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("   ---+---+---");
                Console.WriteLine("2   {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
                Console.WriteLine("              ");
                //使用者輸入x位置
                Console.Write("輸入x位置的座標, 以逗點分隔: ");
                string[] input = new string[2];
                input = Console.ReadLine().Split(',');
                int ix = Convert.ToInt16(input[0]);
                int jx = Convert.ToInt16(input[1]);
                board[ix, jx] = 'x';
                //判斷使用者是否贏了
                int i0 = ix;
                int j0 = jx;
                if (board[i0, 0] == board[i0, 1] && board[i0, 1] == board[i0, 2])
                {
                    Console.WriteLine("使用者獲勝");
                    break;
                }
                if (board[0, j0] == board[1, j0] && board[1, j0] == board[2, j0])
                {
                    Console.WriteLine("使用者獲勝");
                    break;
                }
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    Console.WriteLine("使用者獲勝");
                    break;
                }
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    Console.WriteLine("使用者獲勝");
                    break;
                }
                //電腦選擇o位置
                bool isVacancies = false;
                if (board[i0, j0] == ' ')
                {
                    isVacancies = true;
                }

                do
                {
                    int place = random.Next() % 9;
                    i0 = place / 3;
                    j0 = place % 3;
                } while (isVacancies);
                board[i0, j0] = 'o';
                //判斷使用者是否贏了
                if (board[i0, 0] == board[i0, 1] && board[i0, 1] == board[i0, 2])
                {
                    Console.WriteLine("電腦獲勝");
                    break;
                }
                if (board[0, j0] == board[1, j0] && board[1, j0] == board[2, j0])
                {
                    Console.WriteLine("電腦獲勝");
                    break;
                }
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    Console.WriteLine("電腦獲勝");
                    break;
                }
                if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                {
                    Console.WriteLine("電腦獲勝");
                    break;
                }
            } while (hasVacancies);

        }
    }
}
