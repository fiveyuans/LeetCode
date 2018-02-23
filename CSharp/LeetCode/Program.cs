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
            var list = new List<char>();
            list.Add('a'); 
            list.Add('b');
            list.Add('b');
            list.Add('b');
            list.Add('a');
            list.Add('a');
            list.Add('a');

            var index = list.LastIndexOf('a',2);

            var test = new _003.Longest_Substring_Without_Repeating_Characters();
            var re = test.LengthOfLongestSubstringList("abcabcbb");

        }

    }
}
