using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelPolymorphismExmp
{
    public class ReccuringDepositeAccount : FixedDepositeAccount
    {



        public int maxNumofHoldersPerAcc;

        public void DisplayDetails()
        {
            Console.WriteLine("\nReccuring deposite amount: \n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}", _accId, _accBal, _accName, _accPhonenum, _accMailId, _companyName, _accountType,maxNumofHoldersPerAcc);
        }
    }
}
