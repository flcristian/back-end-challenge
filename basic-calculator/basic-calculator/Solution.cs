using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace basic_calculator
{
    public class Solution
    {
        public int Calculate(string s)
        {
            List<int> strat = new List<int>();
            List<bool> operators = new List<bool>();
            strat.Add(0);
            int current = 0;
            bool add = true;
            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char k = s[i];
                if (!char.IsDigit(k))
                {
                    if (add)
                    {
                        strat[current] += number;
                    }
                    else
                    {
                        strat[current] -= number;
                    }
                    number = 0;
                }

                switch (k)
                {
                    case '(':
                        strat.Add(0);
                        operators.Add(add);
                        add = true;
                        current++;
                        break;
                    case ')':
                        current--;
                        if (operators[current])
                        {
                            strat[current] += strat[current + 1];
                        }
                        else
                        {
                            strat[current] -= strat[current + 1];
                        }
                        strat.RemoveAt(strat.Count - 1);
                        operators.RemoveAt(operators.Count - 1);
                        break;
                    case '-':
                        add = false;
                        break;
                    case '+':
                        add = true;
                        break;
                    case ' ':
                        break;
                    default:
                        number = number * 10 + int.Parse(k.ToString());
                        break;
                }
            }
            if (add)
            {
                strat[current] += number;
            }
            else
            {
                strat[current] -= number;
            }
            number = 0;

            return strat[0];
        }
    }
}
