using System;

namespace SquareRoot
{
    class Program
    {
        public static decimal[] Approximations;
        static void Main(string[] args)
        {
            Approximations = new decimal[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < Approximations.Length; i++)
            {
                var data = Array.ConvertAll(Console.ReadLine().Split(" "), decimal.Parse);
                decimal root = 1;

                if(root == 0)
                {
                    Console.Write(1);
                }
                else
                {
                    for (int j = 0; j < data[1]; j++)
                    {
                        var division = data[0] / root;
                        root = (root + division) / 2;
                    }
                    Approximations[i] = root;
                }

            }

            for (int i = 0; i < Approximations.Length; i++)
            {
                Console.Write(Approximations[i] + " ");
            }
        }
    }
}
