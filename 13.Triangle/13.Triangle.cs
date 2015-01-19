using System;
using System.Globalization;
using System.Threading;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            int aX = int.Parse(Console.ReadLine());
            int aY = int.Parse(Console.ReadLine());
            int bX = int.Parse(Console.ReadLine());
            int bY = int.Parse(Console.ReadLine());
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());

            int A = aX - aY;
            int B = bX - bY;
            int C = cX - cY;

            double distanceAB = Math.Sqrt(
            (bX - aX) * (bX - aX) +
            (bY - aY) * (bY - aY));

            double distanceBC = Math.Sqrt(
                (bX - cX) * (bX - cX) +
                (bY - cY) * (bY - cY));

            double distanceAC = Math.Sqrt(
                (cX - aX) * (cX - aX) +
                (cY - aY) * (cY - aY));

            double p = distanceAB + distanceAC + distanceBC;
            double halfp = p / 2;
            double area = Math.Sqrt(halfp * (halfp - distanceAB) * (halfp - distanceAC) * (halfp - distanceBC));

            if (distanceAB + distanceBC > distanceAC && distanceAB + distanceAC > distanceBC &&
                distanceBC + distanceAC > distanceAB)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0:F2}", area);

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:F2}", distanceAB);
            }
        }
    }
}