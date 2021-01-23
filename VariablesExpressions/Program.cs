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
            int x1 = int.Parse(Console.ReadLine()); //int(整數)parse(剖析)成為數值,double(小數)
            Console.WriteLine("請輸入第二個整數值y :");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" x1 + y1 = {0} ", x1 + y1); //{0}表示依賴的結果(後面第一項)
            Console.WriteLine(" x1 - y1 = {0} ", x1 - y1);
            Console.WriteLine(" x1 * y1 = {0} ", x1 * y1);
            Console.WriteLine(" x1 / y1 = {0} ", x1 / y1); //商
            Console.WriteLine(" x1 % y1 = {0} ", x1 % y1); //餘數
            Console.WriteLine(a0);
            Console.WriteLine("請輸入第一個小數值x :");
            double x2 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("請輸入第二個小數值y :");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" x2 + y2 = {0} ", x2 + y2);
            Console.WriteLine(" x2 - y2 = {0} ", x2 - y2);
            Console.WriteLine(" x2 * y2 = {0} ", x2 * y2);
            Console.WriteLine(" x2 / y2 = {0} ", x2 / y2);
            Console.WriteLine(" x2 % y2 = {0} ", x2 % y2);
            Console.WriteLine(a0);
            Console.WriteLine("Sqrt(2) = " + Math.Sqrt(2.0)); //數學函數前,要加Math
            Console.WriteLine("PI = " + Math.PI);
            Console.WriteLine("Sin(PI/6.0) = " + Math.Sin(Math.PI / 6.0));
            Console.WriteLine("Pow(2.0, 0.5) = " + Math.Pow(2.0, 0.5));
            Console.WriteLine("Exp(1) = " + Math.Exp(1.0));
            Console.WriteLine("ln(e) = " + Math.Log(Math.E));
            Console.WriteLine("log10(100) = " + Math.Log10(100.0));
            const double G = 9.8; //const 避免改掉
            Console.WriteLine("常數G = {0} ", G);
            double t = 1.0;
            double y = -(1.0 / 2.0) * G * t * t;
            Console.WriteLine(y);
            // Error! G = 9.8 / 6
            Console.WriteLine("請輸入整數變數x初值");
            int x0 = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入所要加總的整數值add");
            int add = int.Parse(Console.ReadLine());
            //int x = x0;
            //x = x + add; (=::=assign)
            int x = x0; //x0=12
            x += add; //優化(效率佳)
            Console.WriteLine(x);

            int post;
            int r1 = x0;
            post = r1++; //post=12;r1=13
            Console.WriteLine("post = {0}", post);
            Console.WriteLine(r1);

            int pre;
            int r2 = x0;
            pre = ++r2; //pre=13;r2=13
            Console.WriteLine("pre = {0}",pre);
            Console.WriteLine(r2);

            Console.Write("請輸入一個小於100的整數原始成績");
            int score = int.Parse(Console.ReadLine());
            int result = score < 60 ? 60 : score; //三元運算子(條件?成立:不成立)用在簡單敘述裡
            // 調分公式
            Console.WriteLine("調分後成績: " + result);

            bool w = 7 > 3;
            bool u = 2 < 0;
            bool wORu = w | u;
            bool wANDu = w & u;
            bool wOu = (w & u) | (w | u);
            bool wNu = (w & u) & (w | u);
            Console.WriteLine(w);
            Console.WriteLine(u);
            Console.WriteLine(wORu);
            Console.WriteLine(wANDu);
            Console.WriteLine(wOu);
            Console.WriteLine(wNu);
        }
    }
}
