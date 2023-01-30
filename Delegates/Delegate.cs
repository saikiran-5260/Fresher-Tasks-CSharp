using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExmp
{
    delegate void del(int x, int y);
    public class Delegate
    {
        public static void Add(int x,int y)
        {
            Console.WriteLine(x+y);

        }
        public static void Mul(int x,int y)
        {
            Console.WriteLine(x * y);
        }
    }
}
