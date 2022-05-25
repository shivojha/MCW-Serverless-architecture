using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Problems
{
    public static class TwoSumsEasy
    {
        public static void DataAndTestSteps()
        {
            int[] numbers = { 1, 3, 4, 6, 7 };
            int target = 7;
            //var indexResult = GetNumberIndexesByBruteForce(numbers, target);

            var indexResult = GetNumberIndexesByHashmap(numbers, target);

            if (indexResult.Count == 0)
                Console.WriteLine("Indexes are not found");

            Console.WriteLine($"Indexes Found [{indexResult[0]},{indexResult[1]}]");
        }

        /// <summary>
        /// Brute Force Technique Time: o(n2),  Space : o(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private static List<int> GetNumberIndexesByBruteForce(int[] numbers, int target)
        {
            List<int> foundIndexes = new List<int>();

            for (int outerLoop = 0; outerLoop < numbers.Length; outerLoop++)
            {
                for (int innerLoop = outerLoop + 1; innerLoop < numbers.Length; innerLoop++)
                {
                    if ((numbers[innerLoop] + numbers[outerLoop]) == target)
                    {
                        foundIndexes.AddRange(new int[] { outerLoop, innerLoop });

                        return foundIndexes;
                    }
                }
            }

            return foundIndexes;
        }

        //hashmap same as Dictionary in c#

        // Time o(n) Space(n)
        private static List<int> GetNumberIndexesByHashmap(int[] numbers, int target)
        {
            List<int> foundIndexes = new List<int>();

            var numDict = new Dictionary<int, int>();

            for (int outerLoop = 0; outerLoop < numbers.Length; outerLoop++)
            {
                var requiredNumber = target - numbers[outerLoop];
                if (numDict.ContainsKey(requiredNumber))
                {
                    var value = numDict.GetValueOrDefault(requiredNumber);
                    foundIndexes.AddRange(new int[] { outerLoop, value });
                }
                else
                {
                    numDict.Add(numbers[outerLoop], outerLoop);
                }
            }

            return foundIndexes;
        }
    }
}

