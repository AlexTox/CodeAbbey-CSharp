using System;
using System.Linq;

namespace AverageOfArray
{
    class Program
    {
        public static double[] DigitAverages;
        static void Main(string[] args)
        {
            DigitAverages = new double[Int32.Parse(Console.ReadLine())];


            for (int i = 0; i < DigitAverages.Length; i++)
            {
                var arrayNumbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                DigitAverages[i] = Math.Round(arrayNumbers.Take(arrayNumbers.Length - 1).Average(), MidpointRounding.AwayFromZero);
            }

            Console.Clear();

            for (int i = 0; i < DigitAverages.Length; i++)
            {
                Console.Write(DigitAverages[i] + " ");
            }
        }
    }
}
