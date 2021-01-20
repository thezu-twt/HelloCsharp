using System;

namespace UsingNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 256;
            Console.WriteLine("x : " + x);
            byte y = 255;
            Console.WriteLine("y : " + y);
            double z = 123.45;
            Console.WriteLine("z : " + z);
            float f = 123.45f;
            Console.WriteLine("f : " + f);
            decimal d = 123.45m;
            Console.WriteLine("d : " + d);
        }
    }
}
