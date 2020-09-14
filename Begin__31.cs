using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double T_F,T_C;
            Console.Write("T__F=");
            T_F = double.Parse(Console.ReadLine());
            T_C = (T_F - 32) * 5 / 9;
            Console.WriteLine($"T__C={T_C}");
        }
    }
}
