using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double P = a + b + c;
            Console.WriteLine($"Gipotenuza={c}");
            Console.WriteLine($"Perimetr={P}");
        }
    }
}
