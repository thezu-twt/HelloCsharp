using System;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade;
            double sum = 0.0;
            int n = 0;
            while (true)
            {
                Console.WriteLine("請輸入成績");
                grade = double.Parse(Console.ReadLine());
                if (grade < 0) break;
                Console.WriteLine("成績為 {0}",grade);
                n += 1;
                sum += grade;
            }
            Console.WriteLine("班級人數 {0}", n);
            Console.WriteLine("班級平均 {0}", sum / n);
        }
    }
}
