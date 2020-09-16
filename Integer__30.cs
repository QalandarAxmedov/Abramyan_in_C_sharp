using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y,a;
            Console.Write("Y=");
            Y = int.Parse(Console.ReadLine());
            a = Y / 1000+1;
            Console.Write($"{Y}-yil=> {a} asr");
        }
    }
}
