using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonClass
{
    public  class SingleTon
    {
        private static SingleTon st = new SingleTon();
        private SingleTon()
        {
            Console.WriteLine("SingleTon private constructor is called");
        }

        public static SingleTon Instance
        {
            get
            {
                return st;
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("SingleTon class is called");
        }


    }
}
