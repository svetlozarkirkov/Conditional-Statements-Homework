using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                double temp = a;
                a = b;
                b = temp;
                Console.WriteLine("{0} {1}", a, b);
            }

        }
    }
}
