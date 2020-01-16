using System;

namespace FiveLetterPrint
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] list = {"Grace", "Andy", "Dewey", "Arthur"};
            Program p = new Program();
            PrintFives(list);
        }

        static void PrintFives(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 5)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
