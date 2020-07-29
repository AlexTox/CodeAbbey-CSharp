using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayCounters
{
    class Program
    {
        public static List<Counter> Counters = new List<Counter>();
        static void Main(string[] args)
        {
            var skipProblemData = Console.ReadLine();

            var arrayLetters = Console.ReadLine().Replace(" ", "").ToCharArray();

            for (int i = 0; i < arrayLetters.Length; i++)
            {
                if (Counters.Where(x => x.Letter == arrayLetters[i]).Count() == 0)
                {
                    Counters.Add(new Counter { Letter = arrayLetters[i], Count = 1 });
                }
                else
                {
                    Counters.Where(x => x.Letter == arrayLetters[i]).FirstOrDefault().Count += 1;
                }
            }

            for (int i = 0; i < Counters.Count(); i++)
            {
                Console.Write(Counters[i].Count + " ");
            }
        }
    }

    public class Counter
    {
        public char Letter { get; set; }
        public int Count { get; set; }
    }
}
