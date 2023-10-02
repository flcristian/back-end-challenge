#include "Solution.h"

int main() {
    Solution sol;
    vector<int> x = {1}, y = {};
    sol.merge(x, 1, y, 0);
    for (int i : x) cout << i << " ";
}
