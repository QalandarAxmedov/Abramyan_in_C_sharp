using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, P;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            P = 4 * a;
            Console.Write("P=4*a\na={0} P={1}", a, P);
        }
    }
}
