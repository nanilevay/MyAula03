using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = -8;
            int c;

            c = ++b - a + b;

            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
