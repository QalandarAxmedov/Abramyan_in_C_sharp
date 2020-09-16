using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int L;
            Console.Write("L=");
            L = int.Parse(Console.ReadLine());
            L /= 100;
            Console.Write($"L={L} metr");
        }
    }
}
