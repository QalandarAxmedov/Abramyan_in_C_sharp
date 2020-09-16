using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,a,b;
            Console.Write("Ikki xonali N=");
            N = int.Parse(Console.ReadLine());
            a = N / 10;
            b = N % 10;
            Console.Write($"{N} soni {a} ta o'nlik va {b} ta birlik");
        }
    }
}
