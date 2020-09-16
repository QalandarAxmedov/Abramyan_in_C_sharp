using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,a,b,sum,proiz;
            Console.Write("Ikki xonali N=");
            N = int.Parse(Console.ReadLine());
            a = N / 10;
            b = N % 10;
            sum = a + b;
            proiz = a * b;
            Console.Write($"{N}, {a}+{b}={sum}, {a}*{b}={proiz}");
        }
    }
}
