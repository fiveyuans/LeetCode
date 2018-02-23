using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._003
{
    class Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstringDic(string s)
        {
            int max = 1;
            var chartArray = s.ToCharArray();
            if (chartArray.Length < 1)
            {
                return 0;
            }
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < chartArray.Length; i++)
            {
                if (dic.ContainsKey(chartArray[i]))
                {
                    dic = new Dictionary<char, int>();
                }
                dic.Add(chartArray[i], i);
                if (dic.Count > max)
                {
                    max = dic.Count;
                }

            }
            return max;
        }

        public int LengthOfLongestSubstringList(string s)
        {
            int max = 0;
            var chartArray = s.ToCharArray();
            int arrayLength = chartArray.Length;
            var list = new List<char>();

            for (int i = 0, j = -1; i < arrayLength; i++)
            {
                if (j < 0)
                {
                    j = Math.Max(j, list.IndexOf(chartArray[i]));
                }
                else
                {
                    j = Math.Max(j, list.IndexOf(chartArray[i], j+1));
                }

                max = Math.Max(max, i - j);
                list.Add(chartArray[i]);
            }
            return max;
        }


    }
}
