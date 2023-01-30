using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ededi daxil edin");
            string intpu1 = Console.ReadLine();
            var num1 = Convert.ToInt32(intpu1);

            Console.WriteLine("2ci eded daxil edin");
            string input2 = Console.ReadLine();
            var num2 = Convert.ToInt32(input2);

            Console.WriteLine("3cu ededi daxil edin");
            string input3 = Console.ReadLine();
            var num3 = Convert.ToInt32(input3);

            if (num1 > num2 && num1 > num3)

            {
                Console.WriteLine(num1);

            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }
        }
    }
}
