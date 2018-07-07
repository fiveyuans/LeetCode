using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._004
{
    public class Median_of_Two_Sorted_Arrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var list = new List<int>();
            int i = 0, j = 0;
            while (true)
            {
                if (i >= nums1.Length && j >= nums2.Length)
                {
                    break;
                }
                else if (i < nums1.Length && j < nums2.Length)
                {
                    if (nums1[i] < nums2[j])
                    {
                        list.Add(nums1[i]);
                        i++;

                    }
                    else
                    {
                        list.Add(nums2[j]);
                        j++;
                    }
                }
                else if (i >= nums1.Length)
                {
                    list.Add(nums2[j]);
                    j++;
                }
                else if (j >= nums2.Length)
                {
                    list.Add(nums1[i]);
                    i++;
                }

            }
            if (list.Count == 0)
            {
                return 0;
            }
            if (list.Count % 2 == 0)
            {
                return (list[list.Count / 2] + list[(list.Count / 2) - 1]) / 2.0;
            }
            else
            {
                return list[(list.Count / 2)];
            }

        }
        public double FindMedianSortedArraysFaster(int[] A, int[] B)
        {

            int m = A.Length;
            int n = B.Length;
            if (m > n)
            { // to ensure m<=n
                int[] temp = A; A = B; B = temp;
                int tmp = m; m = n; n = tmp;
            }
            int iMin = 0, iMax = m, halfLen = (m + n + 1) / 2;
            while (iMin <= iMax)
            {
                int i = (iMin + iMax) / 2;
                int j = halfLen - i;
                if (i < iMax && B[j - 1] > A[i])
                {
                    iMin = iMin + 1; // i is too small
                }
                else if (i > iMin && A[i - 1] > B[j])
                {
                    iMax = iMax - 1; // i is too big
                }
                else
                { // i is perfect
                    int maxLeft = 0;
                    if (i == 0) { maxLeft = B[j - 1]; }
                    else if (j == 0) { maxLeft = A[i - 1]; }
                    else { maxLeft = Math.Max(A[i - 1], B[j - 1]); }
                    if ((m + n) % 2 == 1) { return maxLeft; }

                    int minRight = 0;
                    if (i == m) { minRight = B[j]; }
                    else if (j == n) { minRight = A[i]; }
                    else { minRight = Math.Min(B[j], A[i]); }

                    return (maxLeft + minRight) / 2.0;
                }
            }
            return 0.0;


            return 0;
        }

    }
}
