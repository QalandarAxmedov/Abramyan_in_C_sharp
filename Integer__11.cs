using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,n1,n2,n3,sum,proiz;
            Console.Write("Uch xonali N=");
            N = int.Parse(Console.ReadLine());
            n1 = N / 100;
            n2 = N % 100 / 10;
            n3 = N % 10;
            sum = n1 + n2 + n3;
            proiz = n1 * n2 * n3;
            Console.Write($"{n1}+{n2}+{n3}={sum}, {n1}*{n2}*{n3}={proiz}");
        }
    }
}
