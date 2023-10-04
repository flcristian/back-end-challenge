#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int c = 1, k = 0, result[(const int)size(nums)];
        if(size(nums) > 0){
            result[k] = nums[0];
            k++;
        }

        for(int i = 1; i < size(nums);i++){
            if(nums[i] == nums[i-1]) c++;
            else c = 1;

            if(c <= 2) result[k++] = nums[i];
        }
        for(int i = 0;i<k;i++){
            nums[i] = result[i];
        }
        return k;
    }
};