using System;

namespace VariablesExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            double b1;
            b1 = a1; //implicit conversion
            int a2;
            double b2;
            b2 = 20.5;
            a2 = (int)b2; //explicit conversion
            float c0 = 20;
            float c1;
            c1 = 20.5f;
            float c2;
            c2 = (float)20.5; //強制轉成signle float
            char d1 = (char)65;
            Console.WriteLine(b1);
            Console.WriteLine(a2);
            Console.WriteLine(c0);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(d1);
            Char a0 = '\n';
            Console.WriteLine(a0);
            Console.WriteLine("請輸入第一個整數值x :");
            int x = int.Parse(Console.ReadLine()); //int(整數)parse(剖析)成為數值
            Console.WriteLine("請輸入第二個整數值y :");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(" x + y = {0} ", x + y); //{0}表示依賴的結果(後面第一項)
            Console.WriteLine(" x - y = {0} ", x - y);
            Console.WriteLine(" x * y = {0} ", x * y);
            Console.WriteLine(" x / y = {0} ", x / y);
            Console.WriteLine(" x % y = {0} ", x % y);
        }
    }
}
