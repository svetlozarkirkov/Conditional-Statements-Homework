using System;
using System.Globalization;

namespace BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.Write("Please enter the time (hh:mm tt): ");
            string input = Console.ReadLine();
            string format = "h:mm tt";
            DateTime time;
            bool isValid = DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture,
            DateTimeStyles.None, out time);

            if (isValid == true)
            {
                int check = time.Hour;
                if (check >= 3 && check < 13)
                {
                    Console.WriteLine("non-beer time");
                }
                else
                {
                    Console.WriteLine("beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
