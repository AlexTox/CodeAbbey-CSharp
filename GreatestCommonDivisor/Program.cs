using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        public static double[,] NumberPairs;
        public static int CountPairs = 0;
        static void Main(string[] args)
        {
            var CountPairs = Int32.Parse(Console.ReadLine());
            NumberPairs = new double[CountPairs, 2];

            for (int i = 0; i < NumberPairs.Length / 2; i++)
            {
                var numberPair = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                NumberPairs[i, 0] = Nod(numberPair[0], numberPair[1]);
                NumberPairs[i, 1] = Nok(numberPair[0], numberPair[1]);
            }

            for (int i = 0; i < NumberPairs.Length / 2; i++)
            {
                Console.Write(String.Format("({0} {1}) ", NumberPairs[i, 0], NumberPairs[i, 1]));
            }
        }

        private static double Nod(double a, double b)
        {
            if (b < 0)
            {
                b = -b;
            }

            if (a < 0)
            {
                a = -a;
            }

            while (b > 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        private static double Nok(double a, double b)
        {
            return Math.Abs(a * b) / Nod(a, b);
        }
    }
}
