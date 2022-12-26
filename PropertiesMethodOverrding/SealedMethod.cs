

namespace SealedMethodExmp
{
    public class SealedMethod
    {
        protected static int _accId, _accBal;
        protected static string _accName="Test";

        public int accId 
        {
            get
            {
                return _accId;
            }
            set
            {
                _accId = value;
            }
        }
        public virtual int accBal
        {
            get
            {
                return _accBal;
            }
            set 
            { 
                _accBal = value; 
            }
        }
        public string accName
        {
            get
            {
                return _accName;
            }
        }


        public static void DisplayDetails()
        {
            Console.WriteLine("Account Bal: " + _accBal+" "+ _accName+ " "+ _accId);
        }


    }
}
