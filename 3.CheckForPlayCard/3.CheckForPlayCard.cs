using System;
using System.Linq;

namespace CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main()
        {
            string[] validCards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            Console.Write("Character: ");
            string input = Console.ReadLine();
            Console.Write("Valid card sign: ");
            if (validCards.Contains(input))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
