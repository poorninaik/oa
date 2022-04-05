using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*["2", "0089", "-0.1", "+3.14", "4.", "-.9", "2e10", "-90E3", "3e+7", "+6e-1", "53.5e93", "-123.456e789"],
 while the following are not valid numbers: ["abc", "1a", "1e", "e3", "99e2.5", "--6", "-+3", "95a54e53"].*/
namespace oa.Strings
{
    class Number
    {
        public static bool IsValid(string s)
        {
            bool number = false, e = false, dot = false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsDigit(c))
                {
                    number = true;
                }
                else switch (c)
                {
                    case '.':
                    {
                        if (dot || e)
                            return false;
                        dot = true;
                        break;
                    }
                    case 'e':
                    case 'E':
                        if (e || !number)
                            return false;
                        number = false;
                        e = true;
                        break;
                    case '+':
                    case '-':
                        if (i != 0 && s[i - 1] != 'e' && s[i - 1] != 'E')
                            return false;
                        break;
                    default:
                        return false;
                }
            }
            return number;
        }
    }
}
