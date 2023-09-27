using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_dividing_numbers
{
    public class Solution
    {
        bool IsSelfDividing(int number)
        {
            int r = number;

            while (r > 0)
            {
                int c = r % 10;
                if (c == 0 || number % c != 0)
                {
                    return false;
                }
                r /= 10;
            }

            return true;
        }

        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> numbers = new List<int>();

            int i = left;
            while (i <= right)
            {
                if (IsSelfDividing(i))
                {
                    numbers.Add(i);
                }
                i++;
            }

            return numbers;
        }
    }
}
