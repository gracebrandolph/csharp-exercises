using System;

namespace SumList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 5, 2, 3, 5, 8, 13, 21, 88, 4 };
            Program p = new Program();
            int evenSum = p.SumArrayEvens(list);
            Console.WriteLine($"The sum is {evenSum}");
        }

        int SumArrayEvens(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
    }
}
