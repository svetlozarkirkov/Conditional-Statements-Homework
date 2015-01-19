using System;

namespace BiggestOf3Numbers
{
    class BiggestOf3Numbers
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            double max = a;
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            if (b>max)
            {
                max = b;
            }
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            if (c>max)
            {
                max = c;
            }
            Console.WriteLine("Biggest: {0}",max);
        }
    }
}
