using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian;
            Console.Write("Radian=");
            radian = double.Parse(Console.ReadLine());
            radian *= 180 / 3.14;
            Console.WriteLine($"Radian={radian}");
        }
    }
}
