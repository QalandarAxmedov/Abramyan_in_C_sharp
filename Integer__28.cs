using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int K,n,N;
            Console.Write("K=");
            K = int.Parse(Console.ReadLine());
            Console.Write("N=");
            N = int.Parse(Console.ReadLine());
            n = (K + N - 1) % 7;
            Console.Write($"{K}-kun => {n}");
        }
    }
}
