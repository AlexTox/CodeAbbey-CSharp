using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeGuesser
{

    class Program
    {
        private static void Main(string[] args)
        {
            List<string> possibleNums = new List<string>();
            var n = int.Parse(Console.ReadLine());

            bool isFirstLoop = true;

            for (var i = 0; i < n; i++)
            {

                var line = Console.ReadLine().Split(' ');
                var num = line[0];

                if (isFirstLoop)
                {
                    possibleNums = GetNumbers(num.Length);
                }

                var guess = int.Parse(line[1]);

                if (guess == 0)
                {
                    possibleNums.Remove(num);
                }
                else
                {
                    possibleNums = RemoveInvalidNumbers(possibleNums, num, guess);
                }

                isFirstLoop = false;
            }

            Console.WriteLine(possibleNums[0]);
        }

        private static int SameDitigsCount(string a, string b)
        {
            return a.Where((c, i) => c == b[i]).Count();
        }

        private static List<string> RemoveInvalidNumbers(List<string> list, string num, int guess)
        {
            return list.Where(s => SameDitigsCount(s, num) == guess).ToList();
        }

        private static List<string> GetNumbers(int digits)
        {
            return Enumerable.Range(0, (int)Math.Pow(10, digits)).Select(i => i.ToString().PadLeft(digits, '0')).ToList();
        }
    }
}
