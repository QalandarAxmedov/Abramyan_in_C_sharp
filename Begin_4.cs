using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            const double  pi = 3.14;
            double d, L;
            Console.WriteLine("pi={0}",pi);
            Console.WriteLine("L=pi*d");
            Console.Write("d=");
            d = double.Parse(Console.ReadLine());
            L = pi * d;
            Console.Write("L={0}", L);
        }
    }
}
