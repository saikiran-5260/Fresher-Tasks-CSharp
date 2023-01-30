using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDefinedDelegates
{
    //public delegate double AddNumbers(int x, float y,double z);
    //public delegate void AddNumbers1(int x, float y, double z);
    //public delegate bool Status(string str);
    public class Sample
    {
        public static double AddNumbers(int x, float y,double z)
        {
            return x + y + z;
        }
        public static void AddNumbers1(int x, float y,double z) 
        {
            Console.WriteLine("Addition of three numbers: "+(x+y+z));
        }
        public static bool Status(string str)
        {
            if(str.Length>5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
