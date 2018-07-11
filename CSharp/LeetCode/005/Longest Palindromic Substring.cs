using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._005
{
    public class Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {
            int m, n, x, y;
            int rl = 1;

            int l = s.Length;
            if (s.Length <= 1)
            {
                return s;
            }
            var sArray = s.ToCharArray();
            x = 0;
            while (true)
            {

                //start 
                y = x;

                //find same item
                while (true)
                {
                    if (sArray[x] != sArray[++y])
                    {
                        y--;
                        break;
                    }
                }

                //follow two side
                for (int i = 1; i < x; i++)
                {
                    if (y + i <= l)
                    {
                        if (sArray[x - i] == sArray[y + i])
                        {
                            m = x - i;
                            n = y + i;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }


                // update m n


            }


            return "";
        }
    }
}
