using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int K,n;
            Console.Write("K=");
            K = int.Parse(Console.ReadLine());
            n = (K + 1) % 7 + 1;
            Console.Write($"{K}-kun => {n}");
        }
    }
}
