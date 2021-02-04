using System;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int digitAns, digitGuess;
            char[] ansNum = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] answer = new char[4];
            char[] guess;
            int time = 0;
            int maxtime = 2;
            int n, m;
            for (digitAns = 0; digitAns < 4; ++digitAns)
            {
                int remainder = random.Next() % 10;
                answer[digitAns] = ansNum[remainder];
                Console.Write(answer[digitAns]);
            }
            Console.WriteLine("");
            do
            {
                n = 0;
                m = 0;
                Console.Write("請輸入四位數");
                ++time;
                guess = Console.ReadLine().ToCharArray();
                for (digitGuess = 0; digitGuess < 4; ++digitGuess)
                {
                    for (digitAns = 0; digitAns < 4; ++digitAns)
                    {
                        if (guess[digitGuess] != answer[digitAns]) continue;
                        {
                            ++m;
                            if (digitGuess == digitAns) ++n;
                        }
                        break;
                    }
                }
                Console.WriteLine("{0}A{1}B", n, m);
            } while (n != 4 && time < maxtime);
            if (n == 4)
            {
                Console.WriteLine("恭喜答對,答案為{0}{1}{2}{3},共猜了{4}次", answer[0], answer[1], answer[2], answer[3], time);
            }
            else
            {
                Console.WriteLine("答案為{0}{1}{2}{3},共猜了{4}次", answer[0], answer[1], answer[2], answer[3], time);
            }
        }
    }
}
