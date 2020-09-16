using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,n;
            Console.Write("sekund N=");
            N = int.Parse(Console.ReadLine());
            n = N / 3600;
            Console.Write($"{N} sekund = {n} soat");
        }
    }
}
