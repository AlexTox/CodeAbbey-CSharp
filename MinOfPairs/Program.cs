using System;
using System.Linq;

namespace MinOfPairs
{
    class Program
    {

        public static int[] MinOfPairs;
        public static int NumberOfPairs;
        static void Main(string[] args)
        {
            Console.WriteLine("Write number of pairs");
            NumberOfPairs = Int32.Parse(Console.ReadLine());
            MinOfPairs = new int[NumberOfPairs];

            for (int i = 0; i < MinOfPairs.Length; i++)
            {
                var pair = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                MinOfPairs[i] = pair.Min();
            }

            Console.Clear();

            for (int i = 0; i < MinOfPairs.Length; i++)
            {
                Console.Write(MinOfPairs[i] + " ");
            }

        }
    }
}
