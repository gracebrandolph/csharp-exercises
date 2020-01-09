using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double radius;
            Console.WriteLine("Please enter the length of the radius: ");
            userInput = Console.ReadLine();
            radius = double.Parse(userInput);
            while(radius < 0)
            {
                Console.WriteLine("Error. Please enter a positive number: ");
                userInput = Console.ReadLine();
                radius = double.Parse(userInput);
            }
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area is {area}");
        }
    }
}
