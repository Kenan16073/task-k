using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var digitssum = sumofdigits();
                Console.WriteLine(digitssum);
        }
        static int sumofdigits() 
        {
            int num = 555;
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
