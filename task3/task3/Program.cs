using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = sum();
        }
        static int sum()
        {
            int[] numbers = { 1, 2, 3, 4,};
            int sum = 0;
            for(int i=0;i<numbers.Length;i++)
            {
               sum += numbers[i];
            }
            Console.WriteLine(sum);
            return sum;
        }

    }
}
