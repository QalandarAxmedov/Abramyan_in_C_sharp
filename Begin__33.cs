using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double X,A,Y;
            Console.Write("X=");
            X = double.Parse(Console.ReadLine());
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            Console.Write("Y=");
            Y = double.Parse(Console.ReadLine());
            Console.WriteLine($"1kg ={A/X}");
            Console.WriteLine($"{Y} kg={A*Y/X}");
        }
    }
}
