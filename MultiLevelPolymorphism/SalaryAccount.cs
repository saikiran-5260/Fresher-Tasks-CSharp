

namespace MultiLevelPolymorphismExmp
{
    public class SalaryAccount : SavingsAccount
    {

        public string _companyName { set; get; }

        public void DisplayDetails()
        {
            Console.WriteLine("\nSalary account details are: \n{0}\n{1}\n{2}\n{3}\n{4}\n{5}", _accId, _accBal, _accName, _accPhonenum, _accMailId, _companyName);
        }
    }
}
