using System;
using System.Security.Cryptography.X509Certificates;

namespace ArithmeticProgression
{
    class Program
    {
        public static int[] PairSum;
        static void Main(string[] args)
        {
            PairSum = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < PairSum.Length; i++)
            {
                var splittedRow = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                PairSum[i] = ( (splittedRow[0] * 2) + splittedRow[1] * (splittedRow[2] - 1) ) * splittedRow[2] / 2;
            }

            Console.Clear();

            for (int i = 0; i < PairSum.Length; i++)
            {
                Console.Write(PairSum[i]);
            }
        }
    }
}
