using System;

namespace AreaRect
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double width;
            double height;
            Console.Write("Please enter width of rectangle: ");
            userInput = Console.ReadLine();
            width = Convert.ToDouble(userInput);
            Console.Write("Please enter height of rectangle: ");
            userInput = Console.ReadLine();
            height = Convert.ToDouble(userInput);
            Console.WriteLine($"The area of the rectangle is {height * width}");
        }
    }
}
