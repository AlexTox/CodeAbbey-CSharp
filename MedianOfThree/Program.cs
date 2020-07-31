using System;

namespace MedianOfThree
{
    class Program
    {
        public static double[] Medians;
        static void Main(string[] args)
        {
            Medians = new double[int.Parse(Console.ReadLine())];

            for (int i = 0; i < Medians.Length; i++)
            {
                var newNumberLine = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);

                Medians[i] = GetMedian(newNumberLine);
            }

            for (int i = 0; i < Medians.Length; i++)
            {
                Console.Write(Medians[i] + " ");
            }
        }

        public static double GetMedian(double[] sourceNumbers)
        {    
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                throw new System.Exception("Median of empty array not defined.");

            double[] sortedPNumbers = (double[])sourceNumbers.Clone();
            Array.Sort(sortedPNumbers);

            int size = sortedPNumbers.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;

            return median;
        }
    }
}
