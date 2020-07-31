using System;

namespace Palindromes
{
    class Program
    {
        public static bool[] Palindromes;
        static void Main(string[] args)
        {
            Palindromes = new bool[int.Parse(Console.ReadLine())];

            for (int i = 0; i < Palindromes.Length; i++)
            {
                var newNumberLine = Console.ReadLine();

                Palindromes[i] = IsPalindrome(newNumberLine);
            }

            for (int i = 0; i < Palindromes.Length; i++)
            {
                if (Palindromes[i] == true)
                {
                    Console.Write("Y" + " ");
                }
                else if (Palindromes[i] == false)
                {
                    Console.Write("N" + " ");
                }
            }
        }

        public static bool IsPalindrome(string inputSentence)
        {
            string reversedInput = "";

            inputSentence = inputSentence.ToLower();
            inputSentence = inputSentence.Replace(" ", "");
            inputSentence = inputSentence.Replace(",", "");
            inputSentence = inputSentence.Replace(".", "");
            inputSentence = inputSentence.Replace("!", "");
            inputSentence = inputSentence.Replace("?", "");
            inputSentence = inputSentence.Replace("-", "");

            for (int i = (inputSentence.Length - 1); i >= 0; i--)
            {
                reversedInput += inputSentence[i];
            }

            if (reversedInput != inputSentence)
            {
                return false;
            }

            return true;
        }

        
    }
}
