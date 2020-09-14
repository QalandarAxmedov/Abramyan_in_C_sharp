using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradus;
            Console.Write("Gradus=");
            gradus = double.Parse(Console.ReadLine());
            gradus *= 3.14 / 180;
            Console.WriteLine($"Radian={gradus}");
        }
    }
}
