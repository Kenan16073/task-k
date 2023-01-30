using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result=sum(1,2,3,4,5);
            Console.WriteLine(result);
        }
        static int getint() 
        {
         string numbers=Console.ReadLine();
         int num=Convert.ToInt32(numbers);
            return num;
        }

        static int sum(int num1,int num2,int num3 ,int num4,int num5) 
        {
            num1=getint();
            num2=getint();
            num3=getint(); 
            num4=getint();
            num5=getint();
            int result=num1+num2+num3+num4+num5;          
            return result;

        }


    }
}
