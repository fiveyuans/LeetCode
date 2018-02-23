using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace LeetCode._001
{
    class Two_Sum
    {
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

        public int[] TwoSumHashMap(int[] nums, int target)
        {
            Hashtable map = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if (map.ContainsKey(temp))
                {
                    return new int[] { (int)map[temp], i };
                }
                else
                {
                    map.Add(nums[i], i);
                }
            }

            throw new Exception("No solution");

        }
        public int[] TwoSumDic(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    return new int[] { map[target - nums[i]], i };
                }
                map[nums[i]] = i;
                
            }
            return null;
        }
    }
}
