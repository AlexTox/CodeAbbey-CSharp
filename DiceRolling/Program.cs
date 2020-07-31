using System;
using System.Globalization;

namespace DiceRolling
{
    class Program
    {
        public static int[] Numbers;
        public static int MinRange = 1;
        public static int MaxRange = 6;
        static void Main(string[] args)
        {
            Numbers = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < Numbers.Length; i++)
            {
                var newNumberLine = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Numbers[i] = (int) Math.Floor(newNumberLine * (MaxRange)) + MinRange;
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
        }
    }
}
