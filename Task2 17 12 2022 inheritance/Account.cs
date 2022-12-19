using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task217122022
{
    public class Account
    {
        protected int _accId, _accBalance;
        protected string _name,_emailId;

        public int Id
        {
            get
            {
                return _accId;
            }
        }
        public string Name
        {
            get
            {
                return _name;

            }
            set { _name = value; }


        }
        public string EmailId
        {
            get
            {
                return _emailId;
            }
            set { _emailId = value; }
        }
        public void Deposite(int amount)
        {
            Console.WriteLine("Deposite method in Account class");
            _accBalance = _accBalance + amount;
            Console.WriteLine("Account balance after deposite is: {0}",_accBalance);
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Account Id: {0} \nAccount Name: {1} ", _accId, Name);
            Console.WriteLine("Account Balance: {0}",_accBalance);
        }
    }
}
