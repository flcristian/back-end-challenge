using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majority_element
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int element = nums[0], count = 1;
            int i = 1;
            while(i < nums.Length && count <= nums.Length / 2)
            {
                if (count == 0)
                {
                    element = nums[i];
                }
                if (element == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
                i++;
            }
            return element;
        }
    }
}
