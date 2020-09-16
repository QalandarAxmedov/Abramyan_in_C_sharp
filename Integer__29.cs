using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,C,n,N;
            Console.Write("A=");
            A = int.Parse(Console.ReadLine());
            Console.Write("B=");
            B = int.Parse(Console.ReadLine());
            Console.Write("C=");
            C = int.Parse(Console.ReadLine());
            N = (A / C) * (B / C);
            n = A * B - N * N;
            Console.Write($"{N} ta kvadrat va {n} qoldiq yuza");
        }
    }
}
