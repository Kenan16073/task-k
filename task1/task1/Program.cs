using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Sum(11, 22);
            Console.WriteLine(result);
        }
        static int Sum(int num1,int num2)
        {
            var result = num1 + num2;         
            return result;
        }

    }
}
