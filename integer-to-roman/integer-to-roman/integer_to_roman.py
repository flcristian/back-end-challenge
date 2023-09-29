
class Solution(object):
    def intToRoman(self, num):
        result = ""
        romans = [1, 5, 10, 50, 100, 500, 1000]
        letters = [ "I", "V", "X", "L", "C", "D", "M"]
        i = 6
        while num > 0:
            c = num // romans[i]
            num = num % romans[i]
            if i == 6:
                while c > 0:
                    result = letters[i] + result
                    c -= 1 
            elif c == 4:
                result += letters[i] + letters[i + 1] 
            elif c == 9:
                result += letters[i] + letters[i + 2]
            elif c / 5 >= 1:
                result += letters[i + 1]
                c -= 5
                while c > 0:
                    result += letters[i]
                    c -= 1    
            else:
                while c > 0:
                    result += letters[i]
                    c -= 1                
            i -= 2
        return result        
            
solution = Solution()
print(solution.intToRoman(58))