using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            bool Natija;
            Console.Write("A=");
            A = int.Parse(Console.ReadLine());
            Console.Write("B=");
            B = int.Parse(Console.ReadLine());
            Console.Write("C=");
            C = int.Parse(Console.ReadLine());
            Natija = A > 0 | B > 0 | C > 0;
            Console.Write($"{Natija}");
        }
    }
}
