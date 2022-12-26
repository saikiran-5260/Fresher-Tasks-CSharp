
namespace MultiLevelPolymorphismExmp
{
    public class BankAccount
    {
        protected static int _accId, _accBal;
        protected static string _accName, _accPhonenum, _accMailId;


        public int accId
        {
            set
            {
                _accId = value;
            }
            get
            {
                return _accId;
            }
        }
        public int accBal
        {
            set
            {
                _accBal = value;
            }
            get
            {
                return _accBal;
            }
        }
        public string accName
        {
            set
            {
                _accName = value;
            }
            get
            {
                return _accName;
            }
        }
        public string accPhoneNum
        {
            set
            {
                _accPhonenum = value;
            }
            get
            {
                return _accPhonenum;
            }
        }
        public string accEmailId
        {
            set
            {
                _accMailId = value;
            }
            get
            {
                return _accMailId;
            }
        }


        public void MethodOverloading()
        {
            Console.WriteLine("The account holder details are: \n{0}\n{1}\n{2}\n{3}\n{4}",_accId,_accBal,_accName,_accPhonenum,_accMailId);
        }
        public void MethodOverloading(int amount)
        {
            if(amount >= _accBal)
            {
                Console.WriteLine("The amount entered for withdrawl is exceeding the account balance and " +
                    "your available balance is:  " + _accBal);
            }
            else
            {
                _accBal = _accBal - amount;
                Console.WriteLine("The account details after withdraw are: \n{0}\n{1}\n{2}\n{3}\n{4}", _accId, _accBal, _accName, _accPhonenum, _accMailId);
            }
        }

        public virtual void MethodOverriding(int transferamount)
        {
            if (transferamount >= _accBal)
            {
                Console.WriteLine("The amount entered for withdrawl is exceeding the account balance and " +
                    "your available balance is:  " + _accBal);
            }
            else
            {
                _accBal = _accBal - transferamount;
                Console.WriteLine("The account details after withdraw are: \n{0}\n{1}\n{2}\n{3}\n{4}", _accId, _accBal, _accName, _accPhonenum, _accMailId);
            }
        }





























































        //public int accountNum { get; set; }
        //public int accountBal { get; set; }

        //public string accountName { get; set; }

        //public string accHolderphoneNum { get; set; }

        //public string emailID { get; set; }


        ////public BankAccount(int accNum, int accBal, string accName, string accHolderPhone, string emailid)
        ////{
        ////    this.accountNum = accNum;
        ////    this.accountBal = accBal;
        ////    this.accountName = accName;
        ////    this.accHolderphoneNum = accHolderPhone;
        ////    this.emailID = emailid;
        ////}

        //public void OverLoadigMethod(int accNum, int accBal, string accName, string accHolderPhone, string emailid)
        //{
        //    accountNum = accNum;
        //    accountBal = accBal;
        //    accountName = accName;
        //    accHolderphoneNum = accHolderPhone;
        //    emailID = emailid;
        //    Console.WriteLine("Accout details before withdrwal is: \n{0}\n{1}\n{2}\n{3}\n", accountNum, accountBal, accountName, accHolderphoneNum, emailID);
        //}

        //public void OverLoadigMethod(int amount)
        //{
        //    if (amount >= accountBal)
        //    {
        //        Console.WriteLine("insufficient funds please check the amount entered : " + accountBal);
        //    }
        //    else
        //    {
        //        accountBal = accountBal - amount;
        //        Console.WriteLine("Accout details after withdrwal is: \n{0}\n{1}\n{2}\n{3}",
        //            accountNum, accountBal, accountName, accHolderphoneNum, emailID);


        //    }

        //}

        //public virtual void OvverridingMethod(int amount) 
        //{
        //    if (amount >= accountBal)
        //    {
        //        Console.WriteLine("The amount entered is greater than account balance cannot perform transfer: "+ accountBal);
        //    }
        //    else
        //    {
        //        accountBal = accountBal - amount;
        //        Console.WriteLine("The details after transfer is : {0}\n{1}\n{2}\n{3}\n{4}", accountNum, accountBal, accountName, accHolderphoneNum, emailID);
        //    }

        //    Console.WriteLine("Account Balance: " + accountBal);


        //}

    }
}
