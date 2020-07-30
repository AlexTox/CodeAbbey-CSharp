using System;
using System.Linq;

namespace NeumannsRandomGenerator
{
    class Program
    {
        public static int[] RandomNumbers;
        public static int OperationCount;

        static void Main(string[] args)
        {
            OperationCount = Int32.Parse(Console.ReadLine());
            RandomNumbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                int startNumber = RandomNumbers[i];
                int tempNumber = RandomNumbers[i];

                int[] past = Enumerable.Repeat(-1, 1000).ToArray();
                past[0] = RandomNumbers[i];

                int counter = 0;

                while (true)
                {

                    tempNumber = tempNumber * tempNumber;
                    tempNumber = tempNumber / 100;
                    tempNumber = tempNumber % 10000;

                    counter++;

                    if (past.Contains(tempNumber))
                    {
                        past[counter] = tempNumber;
                        break;
                    }

                    past[counter] = tempNumber;

                }

                RandomNumbers[i] = counter;
            }

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                Console.Write(RandomNumbers[i] + " ");
            }
        }
    }
}
