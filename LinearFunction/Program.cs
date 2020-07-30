using System;

namespace LinearFunction
{
    class Program
    {
        public static int[,] PairSpot;
        static void Main(string[] args)
        {
            PairSpot = new int[Int32.Parse(Console.ReadLine()), 2];

            for (int i = 0; i < PairSpot.Length / 2; i++)
            {
                var splittedRow = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                int x1 = splittedRow[0], y1 = splittedRow[1];
                int x2 = splittedRow[2], y2 = splittedRow[3];

                int k = (y2 - y1) / (x2 - x1);
                int b = -(((x1 * y2) - (x2 * y1)) / (x2 - x1) );

                PairSpot[i, 0] = k; PairSpot[i, 1] = b;
            }

            for (int i = 0; i < PairSpot.Length / 2; i++)
            {
                Console.Write("(" + PairSpot[i, 0] + " " + PairSpot[i, 1] + ") ");
            }


        }
    }
}
