from asyncio.windows_events import NULL


class ListNode(object):  
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
    def add_values(self, array):
        if not array:
            return
        self.val = array[0]
        current = self
        for val in array[1:]:
            current.next = ListNode(val)
            current = current.next
            
    def display(self):
        current = self
        while current is not None:
            print(current.val, end=" ") 
            current = current.next

class Solution(object):
    def addTwoNumbers(self, l1, l2):
        result = ListNode()
        r = 0
        x = l1; y = l2
        
        if x is None and y is None:
            result.val = 0
            return result
        
        number = result
        while x is not None and y is not None:
            s = x.val + y.val + r
            number.next = ListNode(s % 10)
            r = s // 10
            x = x.next; y = y.next; number = number.next
        while x is not None:
            s = x.val + r
            number.next = ListNode(s % 10)
            r = s // 10
            x = x.next; number = number.next
        while y is not None:
            s = y.val + r
            number.next = ListNode(s % 10)
            r = s // 10   
            y = y.next; number = number.next
        if r != 0:
            number.next = ListNode(r)
            
        return result.next
            
        
        
solution = Solution()
arr1 = [9,9,9,9]; arr2 = [9,9,9,9,9,9,9]
l1 = ListNode(); l1.add_values(arr1)
l2 = ListNode(); l2.add_values(arr2)
solution.addTwoNumbers(l1,l2).display()
