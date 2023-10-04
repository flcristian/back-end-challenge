#include "Solution.h"

int main() {
    vector<int> x = {0,0,1,1,1,1,2,3,3};
    Solution sol;
    int k = sol.removeDuplicates(x);
    for(int i = 0;i<k;i++) cout << x[i] << " ";
}
