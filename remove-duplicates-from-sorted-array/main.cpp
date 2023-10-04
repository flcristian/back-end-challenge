#include "Solution.h"

int main() {
    vector<int> x = { 98,99,99,100 };
    Solution sol;
    int k = sol.removeDuplicates(x);
    for(int i = 0;i<k;i++) cout << x[i];
}
