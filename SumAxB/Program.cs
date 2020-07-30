using System;
using System.Linq;

namespace SumAxB
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ");

            Console.WriteLine(Int32.Parse(numbers[0]) + Int32.Parse(numbers[1]));
        }


    }
}
