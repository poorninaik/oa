using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Strings
{
    class Parentheses
    {
        public static int Valid(string A)
        {
            var result = 0;
            var stack = new Stack<char>();
            if (A.Length == 0) return 1;
            if (A.Length == 1) return 0;
            foreach (char c in A.ToCharArray())
            {
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || (stack.Peek() != '(' && c == ')')
                        || (stack.Peek() != '{' && c == '}')
                        || (stack.Peek() != '[' && c == ']'))
                        return 0;
                    stack.Pop();
                }
                else stack.Push(c);
            }
            if (stack.Count == 0)
                return 1;
            return result;
        }
    }
}
