using System;

namespace BiggestOf5Numbers
{
    class BiggestOf5Numbers
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            double biggest = a;
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            if (b>biggest)
            {
                biggest = b;
            }
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            if (c > biggest)
            {
                biggest = c;
            }
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            if (d > biggest)
            {
                biggest = d;
            }
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());
            if (e > biggest)
            {
                biggest = e;
            }
            Console.WriteLine("biggest: {0}",biggest);
        }
    }
}
