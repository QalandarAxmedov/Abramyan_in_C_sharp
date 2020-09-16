using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int M;
            Console.Write("M=");
            M = int.Parse(Console.ReadLine());
            M /= 1000;
            Console.Write($"M={M} tonna");
        }
    }
}
