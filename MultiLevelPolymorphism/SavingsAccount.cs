
namespace MultiLevelPolymorphismExmp
{
    public class SavingsAccount : BankAccount
    {

        public override void MethodOverriding(int transferamt)
        {
            if (transferamt >= _accBal)
            {
                Console.WriteLine("\nThe amount entered for transfer is exceeding the account balance and " +
                    "your available balance is:  " + _accBal);
            }
            else
            {
                _accBal = _accBal - transferamt;
                Console.WriteLine("\nThe account details after transfer are: \n{0}\n{1}\n{2}\n{3}\n{4}", _accId, _accBal, _accName, _accPhonenum, _accMailId);

            }







            //public SavingsAccount(int accNum, int accBal, string accName, string accHolderPhone, string emailid) : base(accNum, accBal, accName, accHolderPhone, emailid)
            //{

            //}
            //public override void OvverridingMethod(int amount)
            //{
            //    Console.WriteLine(accountBal);
            //    if (amount >= accountBal)
            //    {
            //        Console.WriteLine("\nThe amount entered is greater than account balance cannot perform transfer: " + accountBal);
            //    }
            //    else
            //    {
            //        accountBal = accountBal - amount;
            //        Console.WriteLine("\nThe details after transfer is : \n{0}\n{1}\n{2}\n{3}\n{4}", accountNum, accountBal, accountName, accHolderphoneNum, emailID);
            //    }
            //}




        }
    }
}
