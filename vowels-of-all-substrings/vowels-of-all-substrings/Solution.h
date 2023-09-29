#include <iostream>
#include <cstring>
#include <string>

using namespace std;

class Solution {
public:
    long long countVowels(string word) {
        long long c = 0, n = word.length();
        for (int i = 0; i < n; i++) {
            if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u') {
                c += (n - i) * (i + 1);
            }
        }
        return c;
    }
};