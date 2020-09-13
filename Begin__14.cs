using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double L, S, R,pi=3.14;
            Console.Write("L=");
            L = double.Parse(Console.ReadLine());
            R= L / (2 * pi);
            S= pi * Math.Pow(R, 2);
            Console.WriteLine($"R={R}\nS={S}");
        }
    }
}
