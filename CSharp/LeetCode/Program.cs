using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        public int[] TwoSum(int[] nums, int target)
        {
            int i;
            int j;
            int k = nums.Length;
            int temp;
            for (i = 0; i < k; i++)
            {
                temp = nums[i];
                for (j = i + 1; j < k; j++)
                {
                    if (temp + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }
            }
            return new int[] { 0, 0 };
        }
        public int[] TwoSumWithHash(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();


            return new int[] { 0, 0 };
        }
    }
}
