using System;

namespace FlowControl
{
    //列舉型別1
    enum WeekDay
    {
        MON = 1,
        TUE = 2,
        WED = 3,
        THU = 4,
        FRI = 5,
        SAT = 6,
        SUN = 7
    }
    //列舉型別2
    enum Season
    {
        SPRING = 1,
        SUMMER = 2,
        FALL = 3,
        WINTER = 4
    }
    //列舉型別3
    enum Grade
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        F = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            //是否為閏年
            Console.WriteLine("please enter the year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Normal Year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Normal Year");
            }

            //檢驗
            bool isLeapYear = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
            string result = (isLeapYear) ? "Leap Year" : "Normal Year";
            Console.WriteLine(result);

            //使用switch成績
            Console.Write("請輸入成績:A, B, C, D, F: ");
            char grade = Console.ReadLine().ToCharArray()[0];
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("成績優異");
                    break;
                case 'B':
                    Console.WriteLine("成績良好");
                    break;
                case 'C':
                    Console.WriteLine("成績中等");
                    break;
                case 'D':
                    Console.WriteLine("成績尚可");
                    break;
                case 'F':
                    Console.WriteLine("不及格");
                    break;
                default:
                    Console.WriteLine("成績錯誤");
                    break;
            }

            //列舉型別1
            WeekDay day = WeekDay.TUE;
            switch (day)
            {
                case WeekDay.MON:
                    Console.WriteLine("星期ㄧ為一週的第{0}天", (int)WeekDay.MON);
                    break;
                case WeekDay.TUE:
                    Console.WriteLine("星期二為一週的第{0}天", (int)WeekDay.TUE);
                    break;
                case WeekDay.WED:
                    Console.WriteLine("星期三為一週的第{0}天", (int)WeekDay.WED);
                    break;
                case WeekDay.THU:
                    Console.WriteLine("星期四為一週的第{0}天", (int)WeekDay.THU);
                    break;
                case WeekDay.FRI:
                    Console.WriteLine("星期五為一週的第{0}天", (int)WeekDay.FRI);
                    break;
                case WeekDay.SAT:
                    Console.WriteLine("星期六為一週的第{0}天", (int)WeekDay.SAT);
                    break;
                case WeekDay.SUN:
                    Console.WriteLine("星期日為一週的第{0}天", (int)WeekDay.SUN);
                    break;
            }

            //列舉型別3
            char symbol;
            Console.Write("請輸入成績:A, B, C, D, F: ");
            symbol = Console.ReadLine().ToCharArray()[0]; //若輸入A, B, C, D, F以外的字母
            if (symbol == 'A' || symbol == 'B'|| symbol =='C'|| symbol =='D'|| symbol == 'F')
            {
                Grade grade1 = (Grade)Enum.Parse(typeof(Grade), Console.ReadLine());
                switch (grade1)
                {
                    case Grade.A:
                        Console.WriteLine("成績優異");
                        break;
                    case Grade.B:
                        Console.WriteLine("成績良好");
                        break;
                    case Grade.C:
                        Console.WriteLine("成績中等");
                        break;
                    case Grade.D:
                        Console.WriteLine("成績尚可");
                        break;
                    case Grade.F:
                        Console.WriteLine("不及格");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("成績輸入錯誤");
            }


            //1~100的偶數和
            int sum = 0;
            int i;
            for (i = 2; i <= 100; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //九九乘法
            int x, y;
            for (x = 1; x <= 9; x++)
            {
                for (y = 1; y <= 9; y++)
                {
                    Console.Write("{0}*{1}={2} ", x, y, x * y); //int換char
                }
                Console.WriteLine(); //換行
            }

            //1/n求加到無限大 //錯了！
            const double THRESHOLD = 1.0e-8;
            double sum1 = 0;
            int n = 1;
            double term = 1; //a0
            while (Math.Abs(term) < THRESHOLD)
            {
                sum1 += term;
                ++n;
                term = 1 / n; //an
            }
            Console.WriteLine(sum1);

            //班級成績登記
            double StuGrade;
            double ClassGrade = 0.0;
            int StuNum = 0;
            while (true)
            {
                Console.WriteLine("請輸入成績");
                StuGrade = double.Parse(Console.ReadLine());
                if (StuGrade < 0) break;
                Console.WriteLine("成績為 {0}", StuGrade);
                StuNum += 1;
                ClassGrade += StuGrade;
            }
            Console.WriteLine("班級人數 {0}", StuNum);
            Console.WriteLine("班級平均 {0}", ClassGrade / StuNum);

            //是不是質數
            Console.WriteLine("請輸入整數");
            int prime = int.Parse(Console.ReadLine());
            int add = 2;
            int answer = 0;
            if (prime == 1 || prime == 2)
            {
                Console.WriteLine("是質數");
            }
            else
            {
                while (add < prime)
                {
                    if (prime % add == 0)
                    {
                        answer = 1;
                        break;
                    }
                    add++;
                }
                if (answer == 1)
                {
                    Console.WriteLine("不是質數");
                }
                else
                {
                    Console.WriteLine("是質數");
                }
            }
        }

    }
}