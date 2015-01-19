using System;
using System.Linq;

namespace Pairs
{
    class Pairs
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] sums = new int[numbers.Length / 2];
            for (int i = 0, j = 0; i < sums.Length; i++)
            {
                sums[i] = numbers[j] + numbers[j + 1];
                j += 2;
            }
            if (sums.Min() == sums.Max())
            {
                Console.WriteLine("Yes, value={0}", sums.Max());
            }
            else
            {
                int maxDiff = 0;
                for (int i = 0; i < sums.Length - 1; i++)
                {
                    int tempDiff = Math.Abs(sums[i] - sums[i + 1]);
                    if (tempDiff > maxDiff)
                    {
                        maxDiff = tempDiff;
                    }
                }
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}