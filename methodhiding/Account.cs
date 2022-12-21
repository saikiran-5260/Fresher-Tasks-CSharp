using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingExmp
{
    public class Account : MethodHiding
    {
        public int accBalance;
        public string location;

        public new void DisplayDetails()
        {
            Console.WriteLine("Account holder account number is: {0},account holder name is: {1},account balance is: " +
                "{2} and location is: {3}",accNumber,accName,accBalance,location);

        }
        
    }
}
