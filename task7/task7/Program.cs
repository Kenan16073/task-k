using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Opposite = opposite("Xeyyam");
            Console.WriteLine(Opposite);
        }
        static string opposite(string str)
        {
            string newstr = "";
            for(int i=str.Length-1; i>=0; i--)
            {
                newstr+= str[i];
            }
            return newstr;
        }
    }
}
