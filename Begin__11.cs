using System;

namespace Abramyan_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            if (a != 0 && b != 0)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                double sum = a + b;
                double ayirma = a - b;
                double kopaytma = a * b;
                double nisbat = a / b;
                Console.WriteLine($"Yigindi={sum}");
                Console.WriteLine($"Ayirma={ayirma}");
                Console.WriteLine($"Kopaytma={kopaytma}");
                Console.WriteLine($"Nisbat={nisbat}");
            }
        }
    }
}
