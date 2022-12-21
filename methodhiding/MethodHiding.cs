using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingExmp
{
    public class MethodHiding
    {
        public int accNumber;
        public string accName;

        public void DisplayDetails()
        {
            Console.WriteLine("Account holder account number is: {0} and account holder name is: {1}" , accNumber,accName);
        }
    }
}
