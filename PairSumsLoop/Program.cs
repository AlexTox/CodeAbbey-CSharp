using System;

namespace PairSumsLoop
{
    class Program
    {
        public static int[] PairsSum;
        public static int PairsCount;

        static void Main(string[] args)
        {
            Console.WriteLine("Count of Pairs");

            PairsCount = Int32.Parse(Console.ReadLine());
            PairsSum = new int[PairsCount];

            for (int i = 0; i < PairsSum.Length; i++)
            {
                var pairs = Console.ReadLine().Split(" ");
                PairsSum[i] = Int32.Parse(pairs[0]) + Int32.Parse(pairs[1]);

                
            }

            for (int i = 0; i < PairsSum.Length; i++)
            {
                Console.Write(PairsSum[i] + " ");
            }
        }
    }
}
