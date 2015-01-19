using System;

namespace PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("\n1 --> int\n2 --> double\n3 --> string\n");
            Console.Write("Choice: ");
            byte choice = byte.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an int: ");
                    int one = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}",one+1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double two = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}",two+1);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string three = Console.ReadLine();
                    Console.WriteLine("Result: {0}*",three);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
