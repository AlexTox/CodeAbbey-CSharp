using System;

namespace SumLoop
{
    class Program
    {
        public static int Sum;
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ");

            foreach (var item in numbers)
            {
                Sum += Int32.Parse(item);
            }

            Console.Clear();
            Console.WriteLine(Sum);
        }
    }
}
