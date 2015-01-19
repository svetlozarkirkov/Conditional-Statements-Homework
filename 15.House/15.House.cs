using System;

namespace House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0, k = n / 2 - 1, m = 1; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', n / 2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', n / 2));
                    Console.WriteLine();
                }
                else if (i > 0 && i < n / 2)
                {
                    Console.Write(new string('.', k));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', m));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', k));
                    Console.WriteLine();
                    k--;
                    m += 2;
                }
                else if (i == n / 2)
                {
                    Console.WriteLine(new string('*', n));
                    k = n / 4;
                    m = n - ((n / 4) * 2) - 2;
                }
                else if (i > n / 2 && i < n - 1)
                {
                    Console.Write(new string('.', k));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', m));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', k));
                    Console.WriteLine();
                }
                else if (i == n - 1)
                {
                    Console.Write(new string('.', k));
                    Console.Write(new string('*', n - (k * 2)));
                    Console.Write(new string('.', k));
                    Console.WriteLine();
                }
            }
        }
    }
}