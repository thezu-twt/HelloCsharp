using System.Diagnostics;

namespace Diagnostics
{
    class Program
    {
        static void Main(string[] args)
        {
            //1~100的偶數和
            int sum = 0;
            int i;
            Debug.Assert(sum == 0);
            for (i = 2; i <= 100; i += 2)
            {
                sum += i;
            }
            Debug.Assert(i == 102);
        }
    }
}
