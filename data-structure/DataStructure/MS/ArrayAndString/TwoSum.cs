using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MS
{
    public class TwoSum
    {
        public static int[] GetTwoSumIndexes_TwoPassSolution(int[] numbers, int target)
        {
            int size = numbers.Length;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < size; i++)
            {
                dict.Add(numbers[i], i);
            }


            int diff = 0;

            for (int i = 0; i < size; i++)
            {
                diff = target - numbers[i];

                if (dict.ContainsKey(diff))
                {
                    int index;
                    dict.TryGetValue(diff, out index);

                    return new int[] { i, index };
                }
            }
            return null;
        }

        public static int[] GetTwoSumIndexes_SinglePass(int[] nums, int target)
        {
            int size = nums.Length;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            int diff = 0;

            for (int i = 0; i < size; i++)
            {
                diff = target - nums[i];
                int index;
                if (dict.TryGetValue(diff, out index))
                {
                    return new int[] { i, index };
                }
                dict[nums[i]] = i;
            }
            return null;
        }
    }
}

