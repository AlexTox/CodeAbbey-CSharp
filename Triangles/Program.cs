using System;

namespace Triangles
{
    class Program
    {
        public static int[] Triangles;
        static void Main(string[] args)
        {
            Triangles = new int[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < Triangles.Length; i++)
            {
                var splittedRow = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                if (((splittedRow[1] + splittedRow[2]) > splittedRow[0]) 
                    & ((splittedRow[0] + splittedRow[1]) > splittedRow[2]) 
                    & ((splittedRow[2] + splittedRow[0]) > splittedRow[1]))
                {
                    Triangles[i] = 1;
                }
                else
                {
                    Triangles[i] = 0;
                }
            }

            Console.Clear();

            for (int i = 0; i < Triangles.Length; i++)
            {
                Console.Write(Triangles[i]);
            }
        }
    }
}
