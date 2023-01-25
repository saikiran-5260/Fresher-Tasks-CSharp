using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerInterfaceImplementation
{
    public class CompareStudent : IComparer<student>
    {
        public int Compare(student? x, student? y)
        {
            if (x.Sid > y.Sid)
                return 1;
            else if(x.Sid<y.Sid) 
                return -1;
            else
                return 0;
        }
    }
}
