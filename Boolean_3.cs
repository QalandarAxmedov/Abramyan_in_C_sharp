using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            bool Natija;
            Console.Write("A=");
            A = int.Parse(Console.ReadLine());
            Natija = A % 2==0;
            Console.Write($"{A}%2==0  is  {Natija} ");
        }
    }
}
