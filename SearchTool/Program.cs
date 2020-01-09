using System;

namespace SearchTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string userInput;
            bool result;
            Console.Write("Enter a string to search: ");
            userInput = Console.ReadLine();
            result = alice.ToLower().Contains(userInput.ToLower());
            if (result)
            {
                Console.Write("String found");
                Console.ReadLine();
            } else
            {
                Console.Write("String not found");
                Console.ReadLine();
            }
        }
    }
}
