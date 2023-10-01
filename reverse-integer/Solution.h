#include <iostream>

using namespace std;

class Solution {
public:
    int reverse(int x) {
        bool negative = x < 0;
        int result = 0;
        while(x != 0){
            if((long)result * 10 + x % 10 > 2147483646 || (long)result * 10 + x % 10 < -2147483647) return 0;
            result = result * 10 + x % 10;
            x /= 10;
        }
        if(negative && result > 0) result *= -1;
        return result;
    }
};

