using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,C,AB,BC,sum;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            Console.Write("B=");
            B = double.Parse(Console.ReadLine());
            Console.Write("C=");
            C = double.Parse(Console.ReadLine());
            AB = Math.Abs(B - A);
            BC = Math.Abs(C - B);
            sum = AB + BC;
            Console.WriteLine($"AB={AB}, BC={BC}, AB+BC={sum}");
        }
    }
}
