using System;
using System.Globalization;

namespace BodyMassIndex
{
    class Program
    {
        public static double[,] PeoplesParameters;
        static void Main(string[] args)
        {
            PeoplesParameters = new double[Int32.Parse(Console.ReadLine()), 2];

            for (int i = 0; i < PeoplesParameters.Length / 2; i++)
            {
                var peopleParameters = Console.ReadLine().Split(" ");

                IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

                PeoplesParameters[i, 0] = double.Parse(peopleParameters[0], formatter);
                PeoplesParameters[i, 1] = double.Parse(peopleParameters[1], formatter);
            }

            for (int i = 0; i < PeoplesParameters.Length / 2; i++)
            {

                var calculatedBMI = CalculateBMI(PeoplesParameters[i,0], PeoplesParameters[i,1]);

                if (calculatedBMI < 18.5)
                {
                    Console.Write("under ");
                }
                else if (calculatedBMI >= 18.5 & calculatedBMI < 25.0)
                {
                    Console.Write("normal ");
                }
                else if (calculatedBMI >= 25.0 & calculatedBMI < 30.0)
                {
                    Console.Write("over ");
                }
                else if (calculatedBMI >= 30.0)
                {
                    Console.Write("under ");
                }

            }
    }

        private static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}
