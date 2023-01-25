using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableInterfaceImplementation
{
    public class sample:ICloneable
    {
        internal protected string Name { get; set; }

        public object Clone()
        {
            return this;
        }
    }
}
