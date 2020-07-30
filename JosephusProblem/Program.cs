using System;

namespace JosephusProblem
{
    class Program
    {
        public static void Main()
        {
            var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine(Josephus(input[0], input[1]));
        }

        static int Josephus(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (Josephus(n - 1, k) + k - 1) % n + 1;
        }


        
    }
}
