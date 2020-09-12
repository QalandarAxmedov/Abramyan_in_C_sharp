using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double d,L,pi=3.14;
            Console.WriteLine("pi=3.14");
            Console.WriteLine("L=pi*d");
            Console.Write("d=");
            d = double.Parse(Console.ReadLine());
            L = pi * d;
            Console.Write("L={0}",L);
        }
    }
}
