using System;

namespace FahrenheitToCelsius
{
    class Program
    {
        public static int[] Celsius;
        static void Main(string[] args)
        {
            Console.WriteLine("Write number of pairs");

            var farengheitNums = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Celsius = new int[farengheitNums.Length - 1];

            Console.WriteLine(farengheitNums[5]);
            for (int i = 0; i < farengheitNums.Length - 1; i++)
            {
                Celsius[i] = (int)Math.Round((decimal)((decimal)(farengheitNums[i + 1] - 32) * 5 / 9), MidpointRounding.AwayFromZero);

            }

            Console.Clear();

            for (int i = 0; i < Celsius.Length; i++)
            {
                Console.Write(Celsius[i] + " ");
            }

        }
    }
}
