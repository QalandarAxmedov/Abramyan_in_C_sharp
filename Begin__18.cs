using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,C,AC,BC,proizved;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            Console.Write("B=");
            B = double.Parse(Console.ReadLine());
            Console.Write("C=");
            C = double.Parse(Console.ReadLine());
            AC = Math.Abs(C - A);
            BC = Math.Abs(C - B);
            proizved = AC * BC;
            Console.WriteLine($"AC={AC}, BC={BC}, AC*BC={proizved}");
        }
    }
}
