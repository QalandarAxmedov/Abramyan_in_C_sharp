using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,C,D,X_1,X_2;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            Console.Write("B=");
            B = double.Parse(Console.ReadLine());
            Console.Write("C=");
            C = double.Parse(Console.ReadLine());
            D = Math.Pow(B, 2) - 4 * A * C;
            X_1 = (-B + Math.Sqrt(D)) / (2 * A);
            X_2 = (-B - Math.Sqrt(D)) / (2 * A);
            Console.WriteLine($"X_1={X_1}\tX_2={X_2}");
        }
    }
}
