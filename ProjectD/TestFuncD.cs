using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectD
{
    public class TestFuncD
    {
        public int Count(int a, int b )
        {
            int count = 0;
            for(int i = a;i<b;i++)
            {
                count += i;
            }
            return count;
        }
    }
}
