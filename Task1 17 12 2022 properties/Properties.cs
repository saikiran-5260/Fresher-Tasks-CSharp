using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Properties
    {
        private int AccId,AccBalance;
        private string Name, EmailId;
        

        public int accId
        {
            get
            {
                Console.WriteLine("Get block is to return the value");
                int id = AccId;
                return id;
                //return AccId;
            }
        }
        public Properties(int accId, int accBalance, string name, string emailId)
        {
            AccId = accId;
            AccBalance = accBalance;
            Name = name;
            EmailId = emailId;
        }
        public int accBalance
        {
            get
            {
                Console.WriteLine("Tyring to view my account balance");
                Console.WriteLine("Please enter the password");
                string pwd = Console.ReadLine();
                if(pwd == "12345")
                {
                    int _accBalance = AccBalance;
                    return _accBalance;
                    //return AccBalance;
                }
                else
                {
                    return -100;
                }
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Account details are: ");
            Console.WriteLine("Account number: " + AccId);
            Console.WriteLine("Account name: " + Name);
            Console.WriteLine("Account balance is: " + AccBalance);
            Console.WriteLine("Account holder emailid : " + EmailId);
        }
    }
}
