using System;

namespace ArrayChecksum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayCount = Int32.Parse(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int checksum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                checksum = ((checksum + array[i]) * 113) % 10000007;
            }


            Console.WriteLine(checksum);
        }
    }
}
