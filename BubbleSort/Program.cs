using System;

namespace BubbleSort
{
    class Program
    {
        private static int counterCycles = 0;
        private static int counterSwap = 0;
        static void Main(string[] args)
        {
            BoggleSort(Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse));

            Console.Write(counterCycles + " " + counterSwap);
        }

        private static int[] BoggleSort(int[] arrayForSort)
        {
            while (true)
            {
                counterCycles++;

                int internalCounter = 0;

                for (int i = 0; i < arrayForSort.Length - 1; i++)
                {
                    if(arrayForSort[i] > arrayForSort[i + 1])
                    {
                        int temp = arrayForSort[i];
                        arrayForSort[i] = arrayForSort[i + 1];
                        arrayForSort[i + 1] = temp;

                        counterSwap++;
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
