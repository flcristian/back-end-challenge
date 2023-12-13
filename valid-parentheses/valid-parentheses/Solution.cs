using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valid_parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> brackets = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        brackets.Push(s[i]);
                        break;
                    case ')':
                        if(brackets.Count != 0 && brackets.Peek() == '(')
                        {
                            brackets.Pop();
                            break;
                        }
                        return false;
                    case '[':
                        brackets.Push(s[i]);
                        break;
                    case ']':
                        if (brackets.Count != 0 && brackets.Peek() == '[')
                        {
                            brackets.Pop();
                            break;
                        }
                        return false;
                    case '{':
                        brackets.Push(s[i]);
                        break;
                    case '}':
                        if (brackets.Count != 0 && brackets.Peek() == '{')
                        {
                            brackets.Pop();
                            break;
                        }
                        return false;
                    default:
                        break;
                }
            }

            return brackets.Count == 0;
        }
    }
}
