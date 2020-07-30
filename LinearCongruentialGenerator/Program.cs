using System;

namespace LinearCongruentialGenerator
{
    class Program
    {
        public static int[] RandomNumbers;
        public static int NumbersCount;

        static void Main(string[] args)
        {
            NumbersCount = Int32.Parse(Console.ReadLine());
            RandomNumbers = new int[NumbersCount]; 

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                var inputFunction = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                int number = inputFunction[3];
                int indexNumber = inputFunction[4];
                int a = inputFunction[0];
                int c = inputFunction[1];
                int m = inputFunction[2];

                for (int z = 0; z < indexNumber; z++)
                {
                    number = ((a * number) + c) % m;
                }

                RandomNumbers[i] = number;
            }

            for (int i = 0; i < RandomNumbers.Length; i++)
            {
                Console.Write(RandomNumbers[i] + " ");
            }
        }
    }
}
