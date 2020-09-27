using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B;
            bool Natija;
            Console.Write("A=");
            A = int.Parse(Console.ReadLine());
            Console.Write("B=");
            B = int.Parse(Console.ReadLine());
            Natija = A > 2 & B <= 3;
            Console.Write($"{A}>2 and {B}>3  is  {Natija} ");
        }
    }
}
