using System;

namespace DataStructure
{
    internal class PalinedromeNumberEasy
    {
        internal static void DataAndTestSteps()
        {
            double number = 1231;
            //number = 1239561654321;

            char[] numbers = number.ToString().ToCharArray();

            int totalDigit = numbers.Length;

            Console.WriteLine($"{number} is palinedrome: {IsPalinedrome(numbers, totalDigit)}");

        }

        private static bool IsPalinedrome(char[] numbers, int totalDigit)
        {
            for (int leftCounter = 0; leftCounter < totalDigit / 2; leftCounter++)
            {

                if (numbers[leftCounter] != numbers[totalDigit - leftCounter - 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}