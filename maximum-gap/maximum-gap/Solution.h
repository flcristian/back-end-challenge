#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    void mergeSort(vector<int>& nums, int left, int right) {
        if (left < right) {
            int mid = (left + right) / 2;
            mergeSort(nums, left, mid);
            mergeSort(nums, mid + 1, right);
            merge(nums, left, right, mid);
        }
    }

    void merge(vector<int>& nums, int left, int right, int mid) {
        int i = left, j = mid + 1, k = 0, temp[100000];
        while (i <= mid && j <= right) {
            if (nums[i] < nums[j]) {
                temp[k] = nums[i];
                i++;
                k++;
            }
            else {
                temp[k] = nums[j];
                j++;
                k++;
            }
        }
        while (i <= mid) {
            temp[k] = nums[i];
            i++;
            k++;
        }
        while (j <= right) {
            temp[k] = nums[j];
            j++;
            k++;
        }
        for (int i = left; i <= right; i++) {
            nums[i] = temp[i - left];
        }
    }

    int maximumGap(vector<int>& nums) {
        if (nums.size() < 2) {
            return 0;
        }

        mergeSort(nums, 0, nums.size() - 1);
        int max = 0;
        for (int i = 1; i < nums.size(); i++) {
            int gap = nums[i] - nums[i - 1];
            if (gap > max) {
                max = gap;
            }
        }
        return max;
    }
};