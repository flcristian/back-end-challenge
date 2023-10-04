#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int freq[201]{}, result[(const int)size(nums)];
        int k = 0;
        for(int i = 0; i < size(nums);i++){
            freq[nums[i] + 100]++;
            if(freq[nums[i] + 100] == 1) result[k++] = nums[i];
        }
        for(int i = 0;i<k;i++){
            nums[i] = result[i];
        }
        return k;
    }
};