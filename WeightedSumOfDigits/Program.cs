using System;

namespace WeightedSumOfDigits
{
    class Program
    {
        public static int[] DigitSums;
        static void Main(string[] args)
        {
            DigitSums = new int[Int32.Parse(Console.ReadLine())];

            var numbersLine = Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse);

            for (int i = 0; i < DigitSums.Length; i++)
            {
                int functionValue = numbersLine[i];

                DigitSums[i] = LongSum(functionValue);
            }

            Console.Clear();

            for (int i = 0; i < DigitSums.Length; i++)
            {
                Console.Write(DigitSums[i] + " ");
            }
        }

        private static int LongSum(int functionValue)
        {
            int sum = 0;
            int digitNumber = 0;
            var functionDigitCount = functionValue.ToString().Length;

            while (functionValue > 0)
            {
                sum += (functionValue % 10) * (functionDigitCount - digitNumber) ;
                functionValue = functionValue / 10;
                digitNumber++;
            }

            return sum;
        }

        private static int ShortSum(int functionValue)
        {
            int sum = 0;
            var stringFunction = Convert.ToString(functionValue);

            for (int i = 0; i < stringFunction.Length; i++)
            {
                sum += (int)stringFunction[i] * i+1;
            }

            return sum;

        }
    }
}
