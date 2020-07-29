using System;

namespace VowelCount
{
    class Program
    {
        public static char[] Vowel = new char[] { 'a', 'o', 'u', 'i', 'e', 'y'};
        public static int[] CharCount;
        static void Main(string[] args)
        {
            CharCount = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < CharCount.Length; i++)
            {
                var data = Console.ReadLine();

                for (int j = 0; j < data.Length; j++)
                {
                        for (int z = 0; z < Vowel.Length; z++)
                        {
                            if (Vowel[z] == data[j]) { CharCount[i]++; }
                        }
                }
            }

            for (int i = 0; i < CharCount.Length; i++)
            {
                Console.Write(CharCount[i] + " ");
            }
        }
    }
}
