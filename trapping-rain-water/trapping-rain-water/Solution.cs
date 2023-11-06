namespace trapping_rain_water;

public class Solution {
    public int Min(int a, int b)
    {
        return a <= b ? a : b;
    }
    
    public int Max(int a, int b)
    {
        return a >= b ? a : b;
    }
    
    public int Trap(int[] height)
    {
        int water = 0;
        int midHeight = 0;

        int left = 0, right = 0;

        int i = 0, j = height.Length - 1;
        bool flag = false;
        while (i < j)
        {
            int current;
            if (flag)
            {
                current = height[i];
            }
            else
            {
                current = height[j];
            }
            
            if (height[i] > left)
            {
                left = height[i];
            }

            if (height[j] > right)
            {
                right = height[j];
            }


            if (current > 0)
            {
                water -= Min(midHeight, current);
            }

            int newHeight = Min(left, right);
            if (newHeight > midHeight)
            {
                water += (newHeight - midHeight) * (j - i - 1);
                midHeight = newHeight;
            }
            
            if (left < right)
            {
                i++;
                flag = true;
            }
            else
            {
                j--;
                flag = false;
            }
        }

        return water;
    }
}