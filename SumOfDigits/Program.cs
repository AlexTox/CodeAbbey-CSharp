using System;

namespace SumOfDigits
{
    class Program
    {
        public static int[] DigitSums;
        static void Main(string[] args)
        {
            DigitSums = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < DigitSums.Length; i++)
            {
                var numbersLine = Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse);
                int functionValue = (numbersLine[0] * numbersLine[1]) + numbersLine[2];

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

            while (functionValue > 0)
            {
                sum += functionValue % 10;
                functionValue = functionValue / 10;
            }

            return sum;
        }

        private static int ShortSum(int functionValue)
        {
            int sum = 0;
            var stringFunction = Convert.ToString(functionValue);

            for (int i = 0; i < stringFunction.Length; i++)
            {
                sum += (int) stringFunction[i];
            }

            return sum;

        }
    }
}
