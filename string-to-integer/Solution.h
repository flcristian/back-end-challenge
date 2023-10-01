#include <iostream>

using namespace std;

class Solution {
public:
    bool isNegativeSign(char character) { return character == 45; }

    bool isPositiveSign(char character) { return character == 43; }

    bool isSpace(char character) { return character == 32; }

    bool isDigit(char character) { return character > 47 && character < 58; }

    int myAtoi(string text) {
        bool negative = false, started = false;
        int result = 0;
        for(char current : text){
            if(isDigit(current)){
                int add = (int)current - 48;
                if (result > (INT_MAX - add) / 10) return negative ? INT_MIN : INT_MAX;
                result = result * 10 + add;
                started = true;
            }
            else if (!started){
                if(isSpace(current)) { }
                else if(isNegativeSign(current)){
                    started = true;
                    negative = true;
                }
                else if(isPositiveSign(current)) { started = true; }
                else{
                    if(negative) return result * -1;
                    return result;
                }
            }
            else if(started){
                if(negative) return result * -1;
                return result;
            }
        }
        if(negative) result *= -1;
        return result;
    }
};