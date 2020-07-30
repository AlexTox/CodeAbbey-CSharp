using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(Console.ReadLine()));
        }


        public static string Reverse(string stringForReverse)
        {
            char[] charArray = stringForReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
