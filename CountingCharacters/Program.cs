using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string test = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            test = test.ToLower();

            foreach (char c in test)
            {
                if (Char.IsLetter(c))
                {
                    if (!chars.ContainsKey(c))
                    {
                        chars.Add(c, 0);
                    }

                    chars[c]++;
                }
            }

            foreach (KeyValuePair<char, int> count in chars)
            {
                Console.WriteLine($"{count.Key}: {count.Value}");
            }

            Console.ReadLine();
        }
    }
}
