using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
