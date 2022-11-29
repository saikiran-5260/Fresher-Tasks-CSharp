

namespace ConstructorExamp
{
    public class AccountDetails
    {
        public int  BrachId,AccountNumber, IfscCode;
        public string AccountHolderName, BranchLocation;
        public bool AccountExisting;
        static int num;

        public AccountDetails()
        {
            Console.WriteLine("Default/userdefined/non-paramerterized constructoe is called");
            
        }
        public AccountDetails(int branchId)
        {
            BrachId = branchId;
            Console.WriteLine("one parameterized constructor is called");
            
        }
        public AccountDetails(int branchId,int AccountNumber)
        {
            this.AccountNumber = AccountNumber;
            BrachId = branchId;
            Console.WriteLine("Two parameterized constructor is called");

        }
        public AccountDetails(int branchId, int AccountNumber, string AccountHolderName )
        {
            this.AccountNumber = AccountNumber;
            BrachId = branchId;
            this.AccountHolderName = AccountHolderName;
            Console.WriteLine("Three parameterized constructor is called");

        }
        public AccountDetails(int branchId, int AccountNumber, string AccountHolderName, int ifscCode)
        {
            this.AccountNumber = AccountNumber;
            BrachId = branchId;
            this.AccountHolderName = AccountHolderName;
            IfscCode = ifscCode;
            Console.WriteLine("Four parameterized constructor is called");

        }
        public AccountDetails(int branchId, int AccountNumber, string AccountHolderName, int ifscCode,string branchLocation)
        {
            this.AccountNumber = AccountNumber;
            BrachId = branchId;
            this.AccountHolderName = AccountHolderName;
            IfscCode = ifscCode;
            BranchLocation = branchLocation;
            Console.WriteLine("Five parameterized constructor is called");

        }
        public AccountDetails(AccountDetails account5)
        {
            this.AccountNumber = account5.AccountNumber;
            BrachId = account5.BrachId;
            this.AccountHolderName = account5.AccountHolderName;
            IfscCode = account5.IfscCode;
            BranchLocation = account5.BranchLocation;
            Console.WriteLine("copy constructor is called");

        }
        
        static AccountDetails()
        {
            num = 5;
            Console.WriteLine("static constructur is called and it can access only static data members only and there should " +
                "be only one static constructor in a class: " + (num =10) );
            Console.WriteLine("\t");
        }
        public void Display()
        {
            Console.WriteLine("bankId is: {0} " , BrachId);
            Console.WriteLine("accountNumber is: " + AccountNumber);
            Console.WriteLine("ifscCode is: " + IfscCode);
            Console.WriteLine("accountHolderName is: " + AccountHolderName);
            Console.WriteLine("branchLocation is: " + BranchLocation);         
            if (AccountNumber != 0)
            {
                AccountExisting = true;
                Console.WriteLine("Account in our bank is existing: " + AccountExisting);
                Console.WriteLine("\t");
            }
            else
            {
                AccountExisting = false;
                Console.WriteLine("Account in our bank is existing: " + AccountExisting);
                Console.WriteLine("\t");
            }

        }
    }
}
