using System;

namespace SortWithIndexes
{
    class Program
    {
        public static int[] StartPositions;
        static void Main(string[] args)
        {
            var inputArray = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            StartPositions = new int[inputArray.Length];

            for (int i = 0; i < StartPositions.Length; i++)
            {
                StartPositions[i] = i + 1;
            }

            BoggleSort(inputArray);

            for (int i = 0; i < StartPositions.Length; i++)
            {
                Console.Write(StartPositions[i] + " ");
            }
        }

        private static int[] BoggleSort(int[] arrayForSort)
        {
            while (true)
            {

                int internalCounter = 0;

                for (int i = 0; i < arrayForSort.Length - 1; i++)
                {
                    if (arrayForSort[i] > arrayForSort[i + 1])
                    {
                        int tempNumber = arrayForSort[i];
                        arrayForSort[i] = arrayForSort[i + 1];
                        arrayForSort[i + 1] = tempNumber;

                        int tempIndex = StartPositions[i];
                        StartPositions[i] = StartPositions[i + 1];
                        StartPositions[i + 1] = tempIndex;

                        internalCounter++;
                    }
                }

                if (internalCounter == 0)
                {
                    break;
                }
            }

            return arrayForSort;
        }

    }
}
