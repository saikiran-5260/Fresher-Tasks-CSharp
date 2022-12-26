
namespace AbstractClassTask
{
    public abstract class BankAccount
    {
        static int _accId, _accBal;
        static string _accName;

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


        public abstract void Withdraw();
        public abstract void Transfer();

        public abstract void DisplayDetails();

    }
}
