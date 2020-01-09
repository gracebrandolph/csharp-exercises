using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            string userInput;
            Console.Write("How many miles have you driven? ");
            userInput = Console.ReadLine();
            miles = Convert.ToDouble(userInput);
            Console.Write("PHow many gallons have you used? ");
            userInput = Console.ReadLine();
            gallons = Convert.ToDouble(userInput);
            Console.WriteLine("Your miles per gallon is {0}", miles / gallons);
        }
    }
}
