using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oa.Bits
{
    class Ones
    {
        public static int numSetBits(int A)
        {
            var ans = new StringBuilder();
            var c = A;
            var r = 0;
            while (c >= 0)
            {
                r = c % 2;
                c = c / 2;
                ans.Append(r);
            }
            return ans.Length;
        }
    }
}
