

namespace MultiLevelPolymorphismExmp
{
    public class FixedDepositeAccount: SalaryAccount
    {
        public string _accountType { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("\nFixed deposite account details: \n{0}\n{1}\n{2}\n{3}\n{4}\n{5}{6}", _accId, _accBal, _accName, _accPhonenum, _accMailId, _companyName, _accountType);
        }

    }
}
