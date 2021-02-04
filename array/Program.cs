using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入人數：");
            int n = int.Parse(Console.ReadLine());
            int i;
            int grade;
            double[] allGrade = new double[n];
            for (i = 0; i < n; ++i)
            {
                Console.Write("請輸入成績：");
                grade = Int32.Parse(Console.ReadLine());
                allGrade[i] = (double)grade;
            }
            for (i = 0; i < allGrade.Length; ++i)
            {
                Console.WriteLine("第{0}位成績為{1}", i + 1, allGrade[i]);
            }

            Random random = new Random();
            const int testNum = 10000;
            int[] counter = new int[10];
            int starNum, remainder, k;
            for (remainder = 0; remainder < 10; ++remainder)
            {
                counter[remainder] = 0;
            }
            for (k = 0; k < testNum; ++k)
            {
                remainder = random.Next() % 10;
                ++counter[remainder];
            }
            for (remainder = 0; remainder < 10; ++remainder)
            {
                starNum = counter[remainder] / 50;
                Console.Write("餘數{0}:", remainder);
                for (k = 0; k < starNum; ++k)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            char[,] square = new char[3, 3];
            square[0, 0] = '4';
            square[0, 1] = '9';
            square[0, 2] = '2';
            square[1, 0] = '3';
            square[1, 1] = '5';
            square[1, 2] = '7';
            square[2, 0] = '8';
            square[2, 1] = '1';
            square[2, 2] = '6';
            int j;
            for (i = 0; i < 3; ++i)
            {
                for (j = 0; j < 3; ++j)
                {
                    Console.Write(square[i, j]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
