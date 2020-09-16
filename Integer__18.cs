using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,n;
            Console.Write("999<N=");
            N = int.Parse(Console.ReadLine());
            n = N / 10000 % 10;
            Console.Write($"{N}, {n}");
        }
    }
}
