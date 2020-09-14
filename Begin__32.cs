using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double T_F,T_C;
            Console.Write("T__C=");
            T_C = double.Parse(Console.ReadLine());
            T_F = 9 * T_C / 5 + 32;
            Console.WriteLine($"T__F={T_F}");
        }
    }
}
