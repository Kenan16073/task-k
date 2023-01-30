using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = sum();
           Console.WriteLine(result);
        }
        static int getint()
        {
            string numbers=Console.ReadLine();
            int number=Convert.ToInt32(numbers);
            return number;
        }
        static int sum() 
        {
            int num1 = getint();
            int num2 = getint();
            var result = num1 + num2;
            return result;
        }



    }
}
