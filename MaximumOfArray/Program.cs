using System;
using System.Linq;

namespace MaximumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var ArrayNumbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            Console.WriteLine(ArrayNumbers.Max() + " " + ArrayNumbers.Min());
        }
    }
}
