using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,n;
            Console.Write("Ikki xonali N=");
            N = int.Parse(Console.ReadLine());
            n = N % 10 * 10 + N / 10;
            Console.Write($"{N}, {n}");
        }
    }
}
