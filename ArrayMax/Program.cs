using System;
using System.Linq;

namespace ArrayMax
{
    class Program
    {

        static void Main(string[] args)
        {
            var maxOfArray = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse).Max();

            Console.WriteLine(maxOfArray);
        }
    }
}