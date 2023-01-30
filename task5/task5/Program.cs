using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1111,2222,3333,4444,5555};
            var max = arrofdigits(numbers);
            Console.WriteLine(max);
        }
        static int arrofdigits(int[] numbers)
        {
            var max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;

        }
    }
}
