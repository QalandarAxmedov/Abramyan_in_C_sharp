using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double R_1, R_2,pi=3.14;
            Console.Write("R__1=");
            R_1 = double.Parse(Console.ReadLine());
            Console.Write("R__2=");
            R_2 = double.Parse(Console.ReadLine());
            double S_1 = pi * Math.Pow(R_1, 2);
            double S_2 = pi * Math.Pow(R_2, 2);
            double S_3 = S_1 - S_2;
            Console.WriteLine($"Halqa yuzasi={S_3}");
        }
    }
}
