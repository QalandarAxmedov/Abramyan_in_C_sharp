using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,n;
            Console.Write("Uch xonali N=");
            N = int.Parse(Console.ReadLine());
            n = N % 10 * 100 + N % 100 / 10 * 10 + N / 100;
            Console.Write($"{N}, {n}");
        }
    }
}
