using System;

namespace RotateString
{
    class Program
    {
        public static string[] RotatedStrings;
        static void Main(string[] args)
        {
            RotatedStrings = new string[Int32.Parse(Console.ReadLine())];

            for (int i = 0; i < RotatedStrings.Length; i++)
            {
                var forRotate = Console.ReadLine().Split(" ");

                RotatedStrings[i] = Rotate(forRotate[1], Int32.Parse(forRotate[0]));
            }

            for (int i = 0; i < RotatedStrings.Length; i++)
            {
                Console.Write(RotatedStrings[i] + " ");
            }
        }

        private static string Rotate(string rotateString, int numSwap)
        {
            if (numSwap > 0)
            {
                return LeftRotate(rotateString, numSwap);
            }
            else if (numSwap < 0)
            {
                return RightRotate(rotateString, Math.Abs(numSwap));
            }
            else
            {
                return rotateString;
            }
        }

        private static String LeftRotate(String rotateString, int numSwap)
        {
            String answer = rotateString.Substring(numSwap, rotateString.Length - numSwap) + rotateString.Substring(0, numSwap);
            return answer;
        }

        private static String RightRotate(String rotateString, int numSwap)
        {
            return LeftRotate(rotateString, rotateString.Length - numSwap);
        }

    }
}
