using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_median_of_two_sorted_arrays
{
    public class Solution
    {
        public static Double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] numbers = nums1.Concat(nums2).OrderBy(n => n).ToArray();
            if (numbers.Count() % 2 == 0)
            {
                return ((double)numbers[numbers.Length / 2] + numbers[numbers.Length / 2 - 1]) / 2;
            }
            return numbers[numbers.Length / 2];
        }
    }
}
