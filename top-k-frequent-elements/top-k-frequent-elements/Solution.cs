using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace top_k_frequent_elements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach(int n in nums)
            {
                int val = freq.GetValueOrDefault(n);
                freq.Remove(n);
                freq.Add(n, val + 1);
            }

            int[] numbers = freq.Keys.ToArray(), frequencies = freq.Values.ToArray();

            bool flag = true;
            int i = 0;
            while(flag && i < numbers.Length)
            {
                flag = false;
                for(int j = numbers.Length - 1; j > i; j--)
                {
                    if (frequencies[j] < frequencies[j - 1])
                    {
                        int n = numbers[j], f = frequencies[j];
                        numbers[j] = numbers[j - 1];
                        frequencies[j] = frequencies[j - 1];
                        numbers[j - 1] = n;
                        frequencies[j - 1] = f;
                        flag = true;
                    }
                }
                i++;
            }

            int[] res = new int[k];
            for(i = 0; i < k; i++)
            {
                res[i] = numbers[numbers.Length - 1 - i];
            }
            return res;
        }
    }
}
