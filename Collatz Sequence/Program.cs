using System;

namespace Collatz_Sequence
{
    class Program
    {
        public static int[] LoopCounters;
        static void Main(string[] args)
        {
             LoopCounters = new int[int.Parse(Console.ReadLine())];
             var newNumberLine = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

             for (int i = 0; i < newNumberLine.Length; i++)
             {
                int number = newNumberLine[i];
                while(number != 1)
                {
                    if (number % 2 == 0)
                    {
                        number = number / 2;
                    }
                    else
                    {
                        number = 3 * number + 1;
                    }
                    LoopCounters[i]++;
                }
             }

            for (int i = 0; i < LoopCounters.Length; i++)
            {
                Console.Write(LoopCounters[i] + " ");
            }
        }
    }
}
