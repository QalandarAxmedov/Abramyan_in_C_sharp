using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,n;
            Console.Write("A=");
            A = int.Parse(Console.ReadLine());
            Console.Write("B=");
            B= int.Parse(Console.ReadLine());
            n = A % B;
            Console.Write($"n={n} qoldiq");
        }
    }
}
