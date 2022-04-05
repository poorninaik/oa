using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Stack
{/*
    Console.WriteLine(BasicCalculator.Solve("add(1,add(2,5))"));
        Console.WriteLine(BasicCalculator.Solve("add(subtract(9,1),add(2,5))"));
        Console.WriteLine(BasicCalculator.Solve("add(add(5,6),subtract(add(2,3),add(subtract(5,1),4)))"));
        Console.WriteLine(BasicCalculator.Solve("45"));*/
    class BasicCalculator
    {
        public static int Solve(string str)
        {
            var result = 0;
            var s = str.Trim().Replace("add", "+").Replace("subtract", "-");
            //var opStr = str.Trim().Replace("subtract", "-");
            var op = new Stack<char>();
            var num = new Stack<int>();
            int curr = 0;
            while (curr < s.Length)
            {
                char c = s[curr++];

                if (char.IsDigit(c))
                {
                    result = (c - '0');
                    continue;
                }
                if (c == ',')
                {
                    num.Push(result);
                    result = 0;
                    continue;
                }
                if (c == '+' || c == '-')
                {
                    op.Push(c);
                    result = 0;
                    continue;
                }
                if (c == ')')
                {
                    int last = num.Pop();
                    char o = op.Pop();
                    result = o == '+' ? last + result : last - result;
                }    
            }
            return result;
        }
    }
}
