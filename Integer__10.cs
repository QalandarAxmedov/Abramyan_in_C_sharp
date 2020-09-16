using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,n,nn;
            Console.Write("Uch xonali N=");
            N = int.Parse(Console.ReadLine());
            n = N%10;
            nn = N % 100 / 10;
            Console.Write($"{N}=_{nn}{n}");
        }
    }
}
