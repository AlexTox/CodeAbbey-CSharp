using System;

namespace Rounding
{
    class Program
    {

        public static int[] RoundedPair;
        static void Main(string[] args)
        {
            Console.WriteLine("Write number of pairs");
            RoundedPair = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < RoundedPair.Length; i++)
            {
                var pair = Array.ConvertAll(Console.ReadLine().Split(" "), Double.Parse);

                RoundedPair[i] = (int) Math.Round((double) (pair[0] / pair[1]), MidpointRounding.AwayFromZero);

            }

            Console.Clear();

            for (int i = 0; i < RoundedPair.Length; i++)
            {
                Console.Write(RoundedPair[i] + " ");
            }

        }
    }
}
