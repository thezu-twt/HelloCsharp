using System;

namespace UsingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1;
            c1 = 'a';
            Console.WriteLine(c1);
            char c2;
            c2 = '文';
            Console.WriteLine(c2);
            char c3;
            c3 = '\x0059'; //x代表16進位數字,代碼為0059
            Console.WriteLine(c3);
            char c4;
            c4 = '\u0058'; //unicode
            Console.WriteLine(c4);
            char c5;
            c5 = '\n'; //next line
            Console.WriteLine(c5);
            char c6;
            c6 = '\''; //'
            Console.WriteLine(c6);
            char c7;
            c7 = '\\'; //\
            Console.WriteLine(c7);
            char c8;
            c8 = '\t'; //tab
            Console.WriteLine(c8);
            char c9;
            c9 = '\a'; //alarm (beep)
            Console.WriteLine(c9);
            char c10;
            c10 = '\b'; //backspace
            Console.WriteLine(c10);
        }
    }
}