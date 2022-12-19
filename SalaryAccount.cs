using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task217122022
{
    public class SalaryAccount:Account
    {
        public SalaryAccount(int intialBalcance, string name,string emailId) 
        {
            _accId = 99898989;
            _accBalance= intialBalcance;
            _name = name;
            _emailId = emailId;

        }
        public void Withdraw(int amount)
        {
            Console.WriteLine("\nWithdraw method in salary account");
            
            if(amount>=_accBalance)
            {
                Console.WriteLine("Insufficient funds in account: {0}", _accBalance);
                Console.WriteLine("Please try amount less than account balance");
            }
            else
            {
                Console.Write("Please enter your 5 digit pin: ");
                string Pin = Console.ReadLine();
                if (Pin == "12345")
                {
                    _accBalance = _accBalance - amount;
                    Console.WriteLine("Withdraw successful");
                    Console.WriteLine("Blance amount after withdraw is: {0}",_accBalance);

                }
                else
                {
                    Console.WriteLine("Pin incorrect please try again");
                }
            }
        }
        public void Transfer()
        {
            Console.WriteLine("\nTransfer method in salary account");
            Console.Write("Enter amount to be transfer: ");
            int transferAmt = int.Parse(Console.ReadLine());
            if (transferAmt>=_accBalance)
            {
                Console.WriteLine("Transfer Amount is greater than account balance\nInsufficient funds" +
                    "\nYour available balance is: {0}", _accBalance);
            }
            else
            {
                Console.Write("Please enter your 5 digit pin: ");
                string Pin = Console.ReadLine();
                if (Pin == "54321") 
                { 
                    _accBalance = _accBalance - transferAmt;
                    Console.WriteLine("Transfer successful");
                    Console.WriteLine("Your account balance after transfer is: {0}", _accBalance);
                }
                else
                {
                    Console.WriteLine("Pin incorrect");
                }
            }

        }
    }
}
