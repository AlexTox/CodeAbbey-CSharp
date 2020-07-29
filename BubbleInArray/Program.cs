using System;
using System.Linq;

namespace BubbleInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberArray = Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse);

            Init(numberArray.Take(numberArray.Length - 1).ToArray());
        }


        private static int CheckSum(int[] numbers)
        {
            int checksum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                checksum = ((checksum + numbers[i]) * 113) % 10000007;
            }

            return checksum;
        }

        private static void Init(int[] numbers)
        {
            int swapCount = 0;

            for (int x = 0; x < (numbers.Length - 1); x++)
            {
                if (x + 1 < numbers.Length)
                {
                    if (numbers[x] > numbers[x + 1])
                    {
                        int temp = numbers[x + 1];
                        numbers[x + 1] = numbers[x];
                        numbers[x] = temp;
                        swapCount++;
                    }
                }
            }

            Console.WriteLine(swapCount + " " + CheckSum(numbers));
        }

        
    }
}
